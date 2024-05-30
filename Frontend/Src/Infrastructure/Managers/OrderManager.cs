namespace Infrastructure.Managers;

public interface IOrderManager
{
    Task<IResult> CreateAsync(CreateOrderRequest request);
}

public class OrderManager(
    IHttpClientFactory factory)
    : IOrderManager
{
    public async Task<IResult> CreateAsync(CreateOrderRequest request)
    {
        var response = await factory.CreateClient(ApplicationConstants.BaseClientName)
            .PostAsJsonAsync(OrderRoutes.Create, request);
        return await response.ToResultAsync();
    }
}