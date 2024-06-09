namespace Infrastructure.Services;

public class OrderService(
    IOrderRepository orderRepository)
    : IOrderService
{
    public async Task<Result<PaginatedData<OrderResponse>>> GetPaginatedOrdersAsync(
        int pageNumber, int pageSize)
    {
        var (ordersEntities, totalCount) = await orderRepository
            .GetPaginatedOrdersAsync(pageNumber, pageSize);
        var ordersResponse = ordersEntities
            .Select(orderEntity =>
                new OrderResponse(
                    LastName: orderEntity.User.LastName,
                    FirstName: orderEntity.User.FirstName,
                    MiddleName: orderEntity.User.MiddleName,
                    PhoneNumber: orderEntity.User.PhoneNumber,
                    Email: orderEntity.User.Email,
                    Message: orderEntity.Message,
                    Arrived: orderEntity.Arrived,
                    Created: orderEntity.Created)).ToList();
        return Result<PaginatedData<OrderResponse>>.Success(new PaginatedData<OrderResponse>
            (List: ordersResponse, TotalCount: totalCount));
    }
    
    public async Task<Result> CreateAsync(CreateOrderRequest request)
    {
        var orderEntity = new OrderEntity {
            UserId = request.UserId,
            Message = request.Message,
            Arrived = request.Arrived.ToUniversalTime()
        };
        await orderRepository.CreateAsync(orderEntity);
        return Result<string>.Success("Заказ успешно создан.");
    }


}