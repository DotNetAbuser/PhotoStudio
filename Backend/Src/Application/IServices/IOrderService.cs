namespace Application.IServices;

public interface IOrderService
{
    Task<Result> CreateAsync(CreateOrderRequest request);
    Task<Result<PaginatedData<OrderResponse>>> GetPaginatedOrdersAsync(
        int pageNumber, int pageSize);
}