namespace Mortgage.Common.Contracts.Events;

public record CustomerCreatedEvent
{
    public Guid CustomerId { get; init; }
    public string Email { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; }
}

public record CustomerUpdatedEvent
{
    public Guid CustomerId { get; init; }
    public DateTime UpdatedAt { get; init; }
}

public record CreditScoreUpdatedEvent
{
    public Guid CustomerId { get; init; }
    public int OldScore { get; init; }
    public int NewScore { get; init; }
    public DateTime UpdatedAt { get; init; }
}
