using TickerViewer.API.Interfaces;
using TickerViewer.Shared.Const;
using TickerViewer.Shared.DTO.Ticket;

namespace TickerViewer.API.Services;

/// <summary>
/// Rest API service.
/// Typed http client.
/// </summary>
public class TicketService(IHttpClientFactory httpClientFactory) : ITicketService
{
    private const string TicketEndpoint = "api/getTickets";

    public async Task<IEnumerable<Ticket>?> GetActualOfferTicketsAsync()
    {
        try
        {
            return await httpClientFactory
                .CreateClient(HttpClientNamesConst.TicketOfferClient)
                .GetFromJsonAsync<IEnumerable<Ticket>>(TicketEndpoint);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
