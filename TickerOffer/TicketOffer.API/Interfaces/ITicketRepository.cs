using TickerViewer.Shared.DTO.Ticket;

namespace TicketOffer.API.Interfaces;

/// <summary>
/// Ticket repository.
/// </summary>
public interface ITicketRepository
{
    IEnumerable<Ticket> GetTickets();
}
