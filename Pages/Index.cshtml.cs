using FleetDesignTaxi.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FleetDesignTaxi.Pages;

public class IndexModel : PageModel
{
    public IReadOnlyList<TransactionRecord> Transactions { get; private set; } = Array.Empty<TransactionRecord>();
    public IReadOnlyList<SmsAlert> SmsAlerts { get; private set; } = Array.Empty<SmsAlert>();
    public IReadOnlyList<NewsItem> News { get; private set; } = Array.Empty<NewsItem>();
    public IReadOnlyList<RevenuePoint> RevenueSeries { get; private set; } = Array.Empty<RevenuePoint>();

    public void OnGet()
    {
        Transactions = new List<TransactionRecord>
        {
            new("Urban Core Loop", 128, 122, 6, 18320m),
            new("Airport Express", 94, 90, 4, 15240m),
            new("Night Line", 64, 60, 4, 9800m),
            new("Suburban Connector", 76, 74, 2, 11260m)
        };

        SmsAlerts = new List<SmsAlert>
        {
            new("Dispatch Team", "System", "Telematics sync completed", "Delivered", DateTime.UtcNow.AddMinutes(-12)),
            new("Driver 204", "Compliance", "Inspection due in 48 hours", "Queued", DateTime.UtcNow.AddMinutes(-45)),
            new("Maintenance HQ", "Maintenance", "EV battery health check scheduled", "Delivered", DateTime.UtcNow.AddHours(-3)),
            new("Driver 118", "Operations", "Route detour activated", "Delivered", DateTime.UtcNow.AddHours(-6))
        };

        News = new List<NewsItem>
        {
            new("Fleet AI copilots reduce idle time by 18%", "Product Update", DateTime.UtcNow.AddDays(-1), "Predictive routing deployed to all premium fleets", "https://example.com/news/ai-copilots"),
            new("Regional compliance bulletin Q2", "Compliance", DateTime.UtcNow.AddDays(-3), "Updated taxi licensing requirements and documentation checklist", "https://example.com/news/compliance-q2"),
            new("Operations leadership summit announced", "Events", DateTime.UtcNow.AddDays(-5), "Join the annual strategy session with peers across global fleets", "https://example.com/news/summit")
        };

        RevenueSeries = Enumerable.Range(0, 12)
            .Select(offset => new RevenuePoint(DateTime.UtcNow.Date.AddMonths(-11 + offset), 9500m + offset * 850m))
            .ToList();

        ViewData["Title"] = "Dashboard";
    }
}
