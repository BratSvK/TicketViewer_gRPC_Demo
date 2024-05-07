using TickerViewer.Shared.DTO.Ticket;
using TickerViewer.Shared.DTO.TicketOdd;

namespace TicketOffer.API.Services;

public static class TicketDB
{
    public static ICollection<Ticket> Tickets { get; set; } = new List<Ticket>
    {
        new() {
            TickerId = 1,
            ActualOdds = new List<Odd>
            {
                new() {
                    OddsRate = 1.5,
                    Status = "Active",
                    OddBetStatusProps = new OddBetStatusProps
                    {
                        EventDate = DateTime.Now,
                        LiveBetting = "Yes",
                        IsLiveBetActive = true,
                        IsBetActive = true
                    }
                },
                new() {
                    OddsRate = 2.5,
                    Status = "Active",
                    OddBetStatusProps = new OddBetStatusProps
                    {
                        EventDate = DateTime.Now,
                        LiveBetting = "No",
                        IsLiveBetActive = false,
                        IsBetActive = true
                    }
                }
            }
        },
        new() {
            TickerId = 2,
            ActualOdds = new List<Odd>
            {
                new() {
                    OddsRate = 1.5,
                    Status = "Active",
                    OddBetStatusProps = new OddBetStatusProps
                    {
                        EventDate = DateTime.Now,
                        LiveBetting = "Yes",
                        IsLiveBetActive = true,
                        IsBetActive = true
                    }
                },
                new() {
                    OddsRate = 2.5,
                    Status = "Active",
                    OddBetStatusProps = new OddBetStatusProps
                    {
                        EventDate = DateTime.Now,
                        LiveBetting = "No",
                        IsLiveBetActive = false,
                        IsBetActive = true
                    }
                }
            }
        }
    };
}
