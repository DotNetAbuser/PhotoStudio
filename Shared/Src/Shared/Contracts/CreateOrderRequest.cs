namespace Shared.Contracts;

public class CreateOrderRequest
{
    [Required] public Guid UserId { get; set; }
    public DateTime Arrived { get; set; } = DateTime.Now.AddHours(2);
    public string Message { get; set; } = string.Empty;
}