using Mortgage.Common.Contracts.Enums;

namespace Mortgage.Common.Contracts.DTOs.Application;

public record LoanApplicationDto
{
    public Guid Id { get; init; }
    public string ApplicationNumber { get; init; } = string.Empty;
    public Guid CustomerId { get; init; }
    public Guid PropertyId { get; init; }
    public Guid? LoanId { get; init; }
    public decimal RequestedAmount { get; init; }
    public decimal DownPayment { get; init; }
    public int RequestedTermMonths { get; init; }
    public ApplicationStatus Status { get; init; }
    public DateTime ApplicationDate { get; init; }
    public DateTime? ApprovalDate { get; init; }
    public DateTime? ClosingDate { get; init; }
    public DateTime CreatedAt { get; init; }
}

public record CreateApplicationDto
{
    public Guid CustomerId { get; init; }
    public Guid PropertyId { get; init; }
    public decimal RequestedAmount { get; init; }
    public decimal DownPayment { get; init; }
    public int RequestedTermMonths { get; init; }
}

public record ApplicationDecisionDto
{
    public Guid ApplicationId { get; init; }
    public bool Approved { get; init; }
    public decimal? ApprovedAmount { get; init; }
    public decimal? ApprovedRate { get; init; }
    public string? DecisionReason { get; init; }
    public List<string>? Conditions { get; init; }
}
