namespace Infrastructure.Routes;

public static class OrderRoutes
{
    private const string BaseUrl = "api/order";

    public static string Create => BaseUrl;

    public static string GetPaginatedOrders(
        int pageNumber, int pageSize) =>
        BaseUrl +
            $"?pageNumber={pageNumber}" +
            $"&pageSize={pageSize}";
}