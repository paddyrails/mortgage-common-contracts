# Mortgage Common Contracts

Shared contracts, DTOs, and event definitions for the Mortgage Application microservices.

## Installation

```bash
dotnet add package Mortgage.Common.Contracts
```

## Contents

### DTOs
- `Customer` - Customer-related DTOs
- `Property` - Property-related DTOs
- `Loan` - Loan-related DTOs
- `Payment` - Payment-related DTOs
- `Application` - Loan Application-related DTOs

### Events
- `CustomerEvents` - Customer domain events
- `PropertyEvents` - Property domain events
- `LoanEvents` - Loan domain events
- `PaymentEvents` - Payment domain events
- `ApplicationEvents` - Application domain events

### Enums
- `LoanStatus`
- `ApplicationStatus`
- `PropertyType`
- `PaymentStatus`
- `EmploymentType`

## Usage

```csharp
using Mortgage.Common.Contracts.DTOs.Customer;
using Mortgage.Common.Contracts.Events;
using Mortgage.Common.Contracts.Enums;

// Use DTOs
var customer = new CustomerDto
{
    Id = Guid.NewGuid(),
    FirstName = "John",
    LastName = "Doe"
};

// Use Events
var evt = new CustomerCreatedEvent
{
    CustomerId = customer.Id,
    CreatedAt = DateTime.UtcNow
};
```

## Building

```bash
dotnet build
dotnet pack
```

## Publishing

```bash
dotnet nuget push bin/Release/Mortgage.Common.Contracts.1.0.0.nupkg --source https://api.nuget.org/v3/index.json --api-key YOUR_API_KEY
```
