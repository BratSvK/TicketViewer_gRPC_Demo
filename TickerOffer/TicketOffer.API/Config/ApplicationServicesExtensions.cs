using TicketOffer.API.Interfaces;
using TicketOffer.API.Services;

namespace TickerViewer.API.Config;

/// <summary>
/// Application services extensions.
/// </summary>
public static class ApplicationServicesExtensions
{
    /// <summary>
    /// Register application services.
    /// </summary>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ITicketRepository, TicketRepository>();

        return services;
    }
}
