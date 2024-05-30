namespace Infrastructure.Services;

public class OrderService(
    IOrderRepository orderRepository)
    : IOrderService
{
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