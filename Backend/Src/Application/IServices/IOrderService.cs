namespace Application.IServices;

public interface IOrderService
{
    Task<Result> CreateAsync(CreateOrderRequest request);
}