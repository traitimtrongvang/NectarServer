using Application.Domain.Services;
using Application.Drivings.Pipelines;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceCollectionExt
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        #region Domain

        services.AddScoped<IGameService, GameService>();

        #endregion
        
        #region Drivings
        
        services.AddMediatR(cfg 
            => cfg.RegisterServicesFromAssembly(typeof(ServiceCollectionExt).Assembly));

        // never change the order of these lines
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationPipeline<,>));
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipeline<,>));

        #endregion
    }
}