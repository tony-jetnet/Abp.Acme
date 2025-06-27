using System;
using CsvHelper.Configuration.Attributes;

namespace Abp.Acme;

public class FaaDocIndexCsv
{
    [Name("TYPE-COLLATERAL")]
    public string TypeCollateral { get; set; } = string.Empty;

    [Name("COLLATERAL")]
    public string Collateral { get; set; } = string.Empty;

    [Name("PARTY")]
    public string Party { get; set; } = string.Empty;

    [Name("DOC-ID")]
    public string DocId { get; set; } = string.Empty;

    [Name("DRDATE")]
    [Format("yyyyMMdd")]
    public DateTime? DrDate { get; set; }

    [Name("PROCESSING-DATE")]
    [Format("yyyyMMdd")] 
    public DateTime? ProcessingDate { get; set; }

    [Name("CORR-DATE")]
    [Format("yyyyMMdd")] 
    public DateTime? CorrDate { get; set; }

    [Name("CORR-ID")]
    public string CorrId { get; set; } = string.Empty;

    [Name("SERIAL-ID")]
    public string SerialId { get; set; } = string.Empty;

    [Name("DOC-TYPE")]
    public string DocType { get; set; } = string.Empty;
}