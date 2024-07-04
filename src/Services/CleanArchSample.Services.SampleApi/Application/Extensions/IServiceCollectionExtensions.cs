using CleanArchSample.Services.SampleApi.Application.SampleEntity.Handlers;

namespace CleanArchSample.Services.SampleApi.Application.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddScoped<AddSampleEntityCommandHandler>();
            services.AddScoped<UpdateSampleEntityCommandHandler>();
            services.AddScoped<DeleteSampleEntityCommandHandler>();
            services.AddScoped<FindSampleEntityByIdQueryHandler>();

            return services;
        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddHandlers();

            return services;
        }
    }
}