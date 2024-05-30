namespace Infrastructure.Repositories;

public class OrderRepository(
    ApplicationDbContext dbContext)
    : IOrderRepository
{
    public async Task CreateAsync(OrderEntity entity)
    {
        await dbContext.Orders.AddAsync(entity);
        await dbContext.SaveChangesAsync();
    }
}