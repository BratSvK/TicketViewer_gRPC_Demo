using TickerViewer.API.Interfaces;
using TickerViewer.Grpc.Shared.Protos;

namespace TickerViewer.API.Services;

/// <summary>
/// gRPC service.
/// </summary>
public class TicketgRPCService(TicketProtoService.TicketProtoServiceClient client) : ITicketService
{
    public async Task<IEnumerable<Shared.DTO.Ticket.Ticket>?> GetActualOfferTicketsAsync()
    {
        var res = await client.GetActualTicketOfferAsync(new ActualTicketRequest());

        return res.ActualTickets.Select(t => new Shared.DTO.Ticket.Ticket
        {
            TickerId = t.TicketId,
            ActualOdds = t.ActualOdds.Select(o => new Shared.DTO.TicketOdd.Odd
            {
                OddsRate = o.OddsRate,
                Status = o.Status,
                OddBetStatusProps = new Shared.DTO.TicketOdd.OddBetStatusProps
                {
                    EventDate = o.OddBetStatusProps.EventDate.ToDateTime(),
                    LiveBetting = o.OddBetStatusProps.LiveBetting,
                    IsLiveBetActive = o.OddBetStatusProps.IsLiveBetActive,
                    IsBetActive = o.OddBetStatusProps.IsBetActive
                }
            })
        });
    }
}
