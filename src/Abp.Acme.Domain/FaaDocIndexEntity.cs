using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Acme;

public class FaaDocIndexEntity : FullAuditedAggregateRoot<Guid>
{
    public string TypeCollateral { get; set; } = string.Empty;

    public string Collateral { get; set; } = string.Empty;

    public string Party { get; set; } = string.Empty;

    public string DocId { get; set; } = string.Empty;

    public DateTime? DrDate { get; set; }

    public DateTime? ProcessingDate { get; set; }

    public DateTime? CorrDate { get; set; }
    
    public string CorrId { get; set; } = string.Empty;

    public string SerialId { get; set; } = string.Empty;

    public string DocType { get; set; } = string.Empty;
}