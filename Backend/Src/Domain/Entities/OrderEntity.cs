namespace Domain.Entities;

public class OrderEntity
    : BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    
    public string Message { get; set; } = string.Empty;
    public DateTime Arrived { get; set; }

    public UserEntity User { get; set; } = default!;
}