namespace CleanArchSample.Services.SampleApi.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services) 
        {
            return services;
        }

        public static IServiceCollection AddStorage(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDatabase();
            services.AddStorage();

            return services;
        }
    }
}