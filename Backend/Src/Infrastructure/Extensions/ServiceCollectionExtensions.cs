namespace Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddHelpers(this IServiceCollection services) =>
        services
            .AddTransient<IUploadFileHelper, UploadFileHelper>();
    
    public static void AddRepositories(this IServiceCollection services) =>
        services
            .AddTransient<IGalleryRepository, GalleryRepository>()
            .AddTransient<IOrderRepository, OrderRepository>()
            .AddTransient<IRoleRepository, RoleRepository>()
            .AddTransient<ISessionRepository, SessionRepository>()
            .AddTransient<IUserRepository, UserRepository>();

    public static void AddServices(this IServiceCollection services) =>
        services
            .AddTransient<IGalleryService, GalleryService>()
            .AddTransient<IOrderService, OrderService>()
            .AddTransient<ITokenService, TokenService>()
            .AddTransient<IUserService, UserService>(); 
}