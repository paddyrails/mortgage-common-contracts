using Mortgage.Common.Contracts.Enums;

namespace Mortgage.Common.Contracts.Events;

public record LoanCreatedEvent
{
    public Guid LoanId { get; init; }
    public Guid CustomerId { get; init; }
    public Guid PropertyId { get; init; }
    public decimal Amount { get; init; }
    public DateTime CreatedAt { get; init; }
}

public record LoanStatusChangedEvent
{
    public Guid LoanId { get; init; }
    public LoanStatus OldStatus { get; init; }
    public LoanStatus NewStatus { get; init; }
    public DateTime ChangedAt { get; init; }
}

public record LoanDisbursedEvent
{
    public Guid LoanId { get; init; }
    public decimal Amount { get; init; }
    public DateTime DisbursedAt { get; init; }
}
