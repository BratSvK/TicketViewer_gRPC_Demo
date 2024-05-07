namespace StreamProcessor.Bayes.Model.Settings;

/// <summary>
/// Bayes Video API settings.
/// </summary>
public class TicketApiSettings
{
    /// <summary>
    /// Appsettings section key
    /// </summary>
    public const string SectionKey = "TicketApi";

    /// <inheritdoc />
    public required string ApiUrl { get; set; }
}
