namespace Mortgage.Common.Contracts.Events;

public record PaymentReceivedEvent
{
    public Guid PaymentId { get; init; }
    public Guid LoanId { get; init; }
    public Guid CustomerId { get; init; }
    public decimal Amount { get; init; }
    public DateTime PaidAt { get; init; }
}

public record PaymentMissedEvent
{
    public Guid LoanId { get; init; }
    public Guid CustomerId { get; init; }
    public DateTime DueDate { get; init; }
    public decimal Amount { get; init; }
}

public record LoanPaidOffEvent
{
    public Guid LoanId { get; init; }
    public Guid CustomerId { get; init; }
    public DateTime PaidOffDate { get; init; }
}
