namespace TickerViewer.Shared.DTO.TicketOdd;

/// <summary>
/// Bet status properties.
/// </summary>
public class OddBetStatusProps
{
    public DateTime EventDate { get; set; }

    public string? LiveBetting { get; set; }

    public bool IsLiveBetActive { get; set; }

    public bool IsBetActive { get; set; }
}
