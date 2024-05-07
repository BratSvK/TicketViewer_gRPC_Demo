namespace TickerViewer.Shared.DTO.TicketOdd;

/// <summary>
/// Odd on ticket.
/// </summary>
public class Odd
{
    public double OddsRate { get; set; }

    public string? Status { get; set; }

    public OddBetStatusProps? OddBetStatusProps { get; set; }
}
