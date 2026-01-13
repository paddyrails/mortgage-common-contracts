namespace Mortgage.Common.Contracts.Enums;

public enum ApplicationStatus
{
    Draft = 0,
    Submitted = 1,
    DocumentsRequested = 2,
    UnderReview = 3,
    Underwriting = 4,
    ConditionalApproval = 5,
    Approved = 6,
    Rejected = 7,
    Withdrawn = 8,
    Funded = 9,
    Closed = 10
}
