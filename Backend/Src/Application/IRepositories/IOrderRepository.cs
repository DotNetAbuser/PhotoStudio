namespace Application.IRepositories;

public interface IOrderRepository
{
    Task CreateAsync(OrderEntity entity);
}