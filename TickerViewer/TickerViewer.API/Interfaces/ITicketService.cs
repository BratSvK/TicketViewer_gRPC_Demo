using TickerViewer.Shared.DTO.Ticket;

namespace TickerViewer.API.Interfaces;

/// <summary>
/// Ticket repository.
/// </summary>
public interface ITicketService
{
   Task<IEnumerable<Ticket>?> GetActualOfferTicketsAsync();
}
