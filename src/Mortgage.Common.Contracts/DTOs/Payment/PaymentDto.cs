using Mortgage.Common.Contracts.Enums;

namespace Mortgage.Common.Contracts.DTOs.Payment;

public record PaymentDto
{
    public Guid Id { get; init; }
    public string PaymentNumber { get; init; } = string.Empty;
    public Guid LoanId { get; init; }
    public Guid CustomerId { get; init; }
    public decimal Amount { get; init; }
    public decimal PrincipalAmount { get; init; }
    public decimal InterestAmount { get; init; }
    public decimal EscrowAmount { get; init; }
    public PaymentStatus Status { get; init; }
    public DateTime DueDate { get; init; }
    public DateTime? PaidDate { get; init; }
    public DateTime CreatedAt { get; init; }
}

public record CreatePaymentDto
{
    public Guid LoanId { get; init; }
    public Guid CustomerId { get; init; }
    public decimal Amount { get; init; }
    public DateTime DueDate { get; init; }
}

public record ProcessPaymentDto
{
    public Guid PaymentId { get; init; }
    public string PaymentMethod { get; init; } = string.Empty;
    public string? AccountNumber { get; init; }
    public string? RoutingNumber { get; init; }
}
