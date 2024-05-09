using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using TickerViewer.Grpc.Shared.Protos;

namespace TicketOffer.API.Services;

public class TicketGrpcService : TicketProtoService.TicketProtoServiceBase
{
    public override Task<ActualTicketResponse> GetActualTicketOffer(ActualTicketRequest request, ServerCallContext context)
    {
        var allTickets = TicketDB.Tickets;
        IList<Ticket> tickets = new List<Ticket>();
        var response = allTickets.Select(t => new Ticket
        {
            TicketId = t.TickerId,
            ActualOdds = { t.ActualOdds?.Select(o => new Odd
            {
                OddsRate = o.OddsRate,
                Status = o.Status,
                OddBetStatusProps = new OddBetStatusProps
                {
                    EventDate = Timestamp.FromDateTime(o.OddBetStatusProps.EventDate.ToUniversalTime()),
                    LiveBetting = o.OddBetStatusProps.LiveBetting,
                    IsLiveBetActive = o.OddBetStatusProps.IsLiveBetActive,
                    IsBetActive = o.OddBetStatusProps.IsBetActive
                }
            }) }
        }).ToList();

        return Task.FromResult(new ActualTicketResponse { ActualTickets = { response } });
    }
}
