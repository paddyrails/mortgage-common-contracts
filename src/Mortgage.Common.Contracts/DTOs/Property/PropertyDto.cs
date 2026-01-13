using Mortgage.Common.Contracts.Enums;

namespace Mortgage.Common.Contracts.DTOs.Property;

public record PropertyDto
{
    public Guid Id { get; init; }
    public string Street { get; init; } = string.Empty;
    public string City { get; init; } = string.Empty;
    public string State { get; init; } = string.Empty;
    public string ZipCode { get; init; } = string.Empty;
    public PropertyType PropertyType { get; init; }
    public int YearBuilt { get; init; }
    public decimal SquareFeet { get; init; }
    public int Bedrooms { get; init; }
    public decimal Bathrooms { get; init; }
    public decimal EstimatedValue { get; init; }
    public DateTime CreatedAt { get; init; }
}

public record CreatePropertyDto
{
    public string Street { get; init; } = string.Empty;
    public string City { get; init; } = string.Empty;
    public string State { get; init; } = string.Empty;
    public string ZipCode { get; init; } = string.Empty;
    public PropertyType PropertyType { get; init; }
    public int YearBuilt { get; init; }
    public decimal SquareFeet { get; init; }
    public int Bedrooms { get; init; }
    public decimal Bathrooms { get; init; }
    public decimal EstimatedValue { get; init; }
}

public record PropertyAppraisalDto
{
    public Guid PropertyId { get; init; }
    public decimal AppraisedValue { get; init; }
    public DateTime AppraisalDate { get; init; }
    public string AppraiserName { get; init; } = string.Empty;
    public string AppraisalCompany { get; init; } = string.Empty;
}
