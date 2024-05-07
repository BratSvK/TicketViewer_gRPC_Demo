using TickerViewer.Shared.DTO.Ticket;
using TicketOffer.API.Interfaces;

namespace TicketOffer.API.Services;

public class TicketRepository : ITicketRepository
{
    public IEnumerable<Ticket> GetTickets() => TicketDB.Tickets;
}
