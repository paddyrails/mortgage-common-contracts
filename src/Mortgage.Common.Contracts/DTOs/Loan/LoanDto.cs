using Mortgage.Common.Contracts.Enums;

namespace Mortgage.Common.Contracts.DTOs.Loan;

public record LoanDto
{
    public Guid Id { get; init; }
    public string LoanNumber { get; init; } = string.Empty;
    public Guid CustomerId { get; init; }
    public Guid PropertyId { get; init; }
    public decimal PrincipalAmount { get; init; }
    public decimal InterestRate { get; init; }
    public int TermMonths { get; init; }
    public decimal MonthlyPayment { get; init; }
    public LoanStatus Status { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime MaturityDate { get; init; }
    public decimal CurrentBalance { get; init; }
    public DateTime CreatedAt { get; init; }
}

public record CreateLoanDto
{
    public Guid CustomerId { get; init; }
    public Guid PropertyId { get; init; }
    public decimal PrincipalAmount { get; init; }
    public decimal InterestRate { get; init; }
    public int TermMonths { get; init; }
}

public record LoanBalanceDto
{
    public Guid LoanId { get; init; }
    public decimal PrincipalBalance { get; init; }
    public decimal InterestBalance { get; init; }
    public decimal EscrowBalance { get; init; }
    public decimal TotalBalance { get; init; }
    public DateTime AsOfDate { get; init; }
}
