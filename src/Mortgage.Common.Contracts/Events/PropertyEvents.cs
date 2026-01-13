namespace Mortgage.Common.Contracts.Events;

public record PropertyCreatedEvent
{
    public Guid PropertyId { get; init; }
    public string Address { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
}

public record PropertyAppraisedEvent
{
    public Guid PropertyId { get; init; }
    public decimal AppraisedValue { get; init; }
    public DateTime AppraisalDate { get; init; }
}
