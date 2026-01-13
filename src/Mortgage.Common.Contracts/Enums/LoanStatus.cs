namespace Mortgage.Common.Contracts.Enums;

public enum LoanStatus
{
    Draft = 0,
    Submitted = 1,
    UnderReview = 2,
    Approved = 3,
    Rejected = 4,
    Funded = 5,
    Active = 6,
    PaidOff = 7,
    Defaulted = 8,
    Foreclosed = 9
}
