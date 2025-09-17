using FleetDesignTaxi.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FleetDesignTaxi.Pages;

public class AutoServicesModel : PageModel
{
    public IReadOnlyList<AutoServiceEntry> Services { get; private set; } = Array.Empty<AutoServiceEntry>();

    public void OnGet()
    {
        Services = new List<AutoServiceEntry>
        {
            new("Autofix Labs", "Battery Diagnostics", "EV-204", "TX-9821", "Kyla Flores", "service@autofix.io", "Active", DateTime.UtcNow.AddDays(-17), DateTime.UtcNow.AddDays(13), 4200m),
            new("Metro Motors", "Brake Calibration", "SUV-114", "TX-7782", "Miguel Costa", "metro@motors.com", "Active", DateTime.UtcNow.AddDays(-33), DateTime.UtcNow.AddDays(27), 1680m),
            new("Urban Detailers", "Interior Detox", "Sedan-452", "TX-2345", "Aisha Rahim", "hello@urbandetailers.com", "Archived", DateTime.UtcNow.AddDays(-80), DateTime.UtcNow.AddDays(-10), 350m),
            new("Skyline Workshop", "Suspension Overhaul", "SUV-834", "TX-6543", "Jonah Bishop", "contact@skylineworkshop.com", "Active", DateTime.UtcNow.AddDays(-12), DateTime.UtcNow.AddDays(40), 2680m),
            new("Quantum Lube", "Oil Replacement", "Sedan-298", "TX-9043", "Ada Mendez", "ops@quantumlube.com", "Not Active", DateTime.UtcNow.AddDays(-120), DateTime.UtcNow.AddDays(-20), 220m),
            new("Prime Auto Care", "Telematics Retrofit", "EV-390", "TX-3321", "Lee Carter", "support@primeauto.com", "Active", DateTime.UtcNow.AddDays(-5), DateTime.UtcNow.AddDays(50), 5200m)
        };

        ViewData["Title"] = "Auto Services";
    }
}
