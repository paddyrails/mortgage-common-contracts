namespace Mortgage.Common.Contracts.DTOs.Customer;

public record CustomerDto
{
    public Guid Id { get; init; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public string SSN { get; init; } = string.Empty;
    public DateTime DateOfBirth { get; init; }
    public AddressDto? Address { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
}

public record AddressDto
{
    public string Street { get; init; } = string.Empty;
    public string City { get; init; } = string.Empty;
    public string State { get; init; } = string.Empty;
    public string ZipCode { get; init; } = string.Empty;
    public string Country { get; init; } = "USA";
}

public record CreateCustomerDto
{
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public string SSN { get; init; } = string.Empty;
    public DateTime DateOfBirth { get; init; }
    public AddressDto? Address { get; init; }
}

public record UpdateCustomerDto
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Email { get; init; }
    public string? Phone { get; init; }
    public AddressDto? Address { get; init; }
}

public record CustomerCreditDto
{
    public Guid CustomerId { get; init; }
    public int CreditScore { get; init; }
    public string CreditRating { get; init; } = string.Empty;
    public DateTime ReportDate { get; init; }
}
