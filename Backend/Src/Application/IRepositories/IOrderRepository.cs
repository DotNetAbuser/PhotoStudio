namespace Application.IRepositories;

public interface IOrderRepository
{
    Task CreateAsync(OrderEntity entity);
    Task<PaginatedData<OrderEntity>> GetPaginatedOrdersAsync(
        int pageNumber, int pageSize);
}