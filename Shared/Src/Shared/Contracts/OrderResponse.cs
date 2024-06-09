namespace Shared.Contracts;

public record OrderResponse(
    string LastName,
    string FirstName,
    string? MiddleName,
    string PhoneNumber,
    string Email,
    string Message,
    DateTime Arrived,
    DateTime Created);