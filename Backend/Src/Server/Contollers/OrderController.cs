namespace Server.Contollers;

[ApiController]
[Route("api/order")]
public class OrderController(
    IOrderService orderService)
    : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateOrderRequest request)
    {
        return Ok(await orderService.CreateAsync(request));
    }
}