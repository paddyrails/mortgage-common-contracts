using Mortgage.Common.Contracts.Enums;

namespace Mortgage.Common.Contracts.Events;

public record ApplicationSubmittedEvent
{
    public Guid ApplicationId { get; init; }
    public Guid CustomerId { get; init; }
    public decimal RequestedAmount { get; init; }
    public DateTime SubmittedAt { get; init; }
}

public record ApplicationStatusChangedEvent
{
    public Guid ApplicationId { get; init; }
    public ApplicationStatus OldStatus { get; init; }
    public ApplicationStatus NewStatus { get; init; }
    public DateTime ChangedAt { get; init; }
}

public record ApplicationApprovedEvent
{
    public Guid ApplicationId { get; init; }
    public Guid CustomerId { get; init; }
    public decimal ApprovedAmount { get; init; }
    public decimal InterestRate { get; init; }
    public DateTime ApprovedAt { get; init; }
}

public record ApplicationRejectedEvent
{
    public Guid ApplicationId { get; init; }
    public Guid CustomerId { get; init; }
    public string Reason { get; init; } = string.Empty;
    public DateTime RejectedAt { get; init; }
}
