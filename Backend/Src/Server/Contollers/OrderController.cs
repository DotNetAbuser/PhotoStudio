namespace Server.Contollers;

[ApiController]
[Route("api/order")]
public class OrderController(
    IOrderService orderService)
    : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPaginatedOrders(
        int pageNumber, int pageSize)
    {
        return Ok(await orderService.GetPaginatedOrdersAsync(pageNumber, pageSize));
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateOrderRequest request)
    {
        return Ok(await orderService.CreateAsync(request));
    }
}