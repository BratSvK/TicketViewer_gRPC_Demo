using Microsoft.Extensions.Options;
using StreamProcessor.Bayes.Model.Settings;
using TickerViewer.API.Interfaces;
using TickerViewer.API.Services;
using TickerViewer.Shared.Const;
using TickerViewer.Shared.Enum;
using TicketOffer.API.Protos;

namespace TickerViewer.API.Config;

/// <summary>
/// Application services extensions.
/// </summary>
public static class ApplicationServicesExtensions
{
    /// <summary>
    /// Register Bayes video typed http client.
    /// </summary>
    public static IServiceCollection AddTicketApiClient(this IServiceCollection services)
    {
        services.AddHttpClient(HttpClientNamesConst.TicketOfferClient, (sc, client) =>
        {
            var settings = sc.GetRequiredService<IOptions<TicketApiSettings>>().Value;
            client.BaseAddress = new Uri(settings.ApiUrl);
        });

        return services;
    }

    /// <summary>
    /// Register application services.
    /// </summary>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddKeyedScoped<ITicketService, TicketService>(KeyedServiceType.REST);
        services.AddKeyedScoped<ITicketService, TicketgRPCService>(KeyedServiceType.gRPC);

        return services;
    }

    /// <summary>
    /// Add Grpc client.
    /// </summary>
    public static IServiceCollection AddGrpcClient(this IServiceCollection services, IConfiguration config)
    {
        services.AddGrpcClient<TicketProtoService.TicketProtoServiceClient>(o => o.Address = new Uri(config["GrpcSettings:TicketOffer"]!));

        return services;
    }

    /// <summary>
    /// Register appplication settings.
    /// </summary>
    public static IServiceCollection AddAppOptions(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<TicketApiSettings>(config.GetSection(TicketApiSettings.SectionKey));

        return services;
    }
}
