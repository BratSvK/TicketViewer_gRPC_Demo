using TickerViewer.Shared.DTO.TicketOdd;

namespace TickerViewer.Shared.DTO.Ticket;

/// <summary>
/// Ticker DTO.
/// </summary>
public class Ticket
{
    public int TickerId { get; set; }

    public IEnumerable<Odd>? ActualOdds { get; set; }
}
