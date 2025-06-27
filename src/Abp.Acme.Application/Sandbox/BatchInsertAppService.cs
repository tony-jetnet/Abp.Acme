using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Volo.Abp.Domain.Repositories;

namespace Abp.Acme.Sandbox;

public class BatchInsertAppService(IRepository<FaaDocIndexEntity, Guid> repository)
    : AcmeAppService, IBatchInsertAppService
{
    public async Task<int> GetRun()
    {
        using var streamReader = new StreamReader(Path.Combine(AppContext.BaseDirectory, "PUBLIC_FAA_DOCINDEX.txt"));
        using var csvReader = new CsvReader(streamReader, new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Mode = CsvMode.NoEscape,
            TrimOptions = TrimOptions.Trim,
            PrepareHeaderForMatch = x => x.Header.Trim(),
            MissingFieldFound = null,
            IgnoreBlankLines = true
        });
        var records = csvReader.GetRecords<FaaDocIndexCsv>().ToList();
        var entities = ObjectMapper.Map<List<FaaDocIndexCsv>, List<FaaDocIndexEntity>>(records);

        //Batch insert
        var batchSize = 3000;
        var numberOfBatches = (int)Math.Ceiling(entities.Count / (double)batchSize);

        for (var i = 0; i < numberOfBatches; i++)
        {
            var batch = entities.Skip(i * batchSize).Take(batchSize);

            await repository.InsertManyAsync(batch, true);
        }

        return entities.Count;
    }
}