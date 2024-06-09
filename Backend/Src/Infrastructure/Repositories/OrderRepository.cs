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

    public async Task<PaginatedData<OrderEntity>> GetPaginatedOrdersAsync(
        int pageNumber, int pageSize)
    {
        var getListQuery = dbContext.Orders
            .OrderByDescending(x => x.Created)
            .AsNoTracking();
        var countQuery = dbContext.Orders
            .AsNoTracking();
        
        var list = await getListQuery
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Include(x => x.User)
            .ToListAsync();
        var totalCount = await countQuery
            .CountAsync();
        return new PaginatedData<OrderEntity>(
            List: list, TotalCount: totalCount);
    }
}