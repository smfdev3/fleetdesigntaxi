using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FleetDesignTaxi.Pages;

public class SettingsModel : PageModel
{
    public record SettingSection(string Title, string Accent, string Description, IEnumerable<SettingLink> Links);
    public record SettingLink(string Label, string Url, string IconClass);

    public IReadOnlyList<SettingSection> Sections { get; private set; } = Array.Empty<SettingSection>();

    public void OnGet()
    {
        Sections = new List<SettingSection>
        {
            new("Vehicle Setting", "azure", "Manage fleet vehicle archetypes, classes and telematics tags", new []
            {
                new SettingLink("Vehicle Types", "#", "bi-car-front"),
                new SettingLink("Taxi Tags", "#", "bi-tags"),
                new SettingLink("Vehicle Group", "#", "bi-diagram-3"),
                new SettingLink("Driver Pool", "#", "bi-people"),
                new SettingLink("Employee Card", "#", "bi-credit-card-2-front")
            }),
            new("Accident Setting", "amber", "Standardize emergency protocols and field reporting flows", new []
            {
                new SettingLink("Police Protocol", "#", "bi-shield-exclamation"),
                new SettingLink("Claim Forms", "#", "bi-file-earmark-text"),
                new SettingLink("Incident Templates", "#", "bi-journal-text"),
                new SettingLink("Response Contacts", "#", "bi-telephone-forward"),
            }),
            new("General Setting", "emerald", "Organization-wide tax, billing and integration preferences", new []
            {
                new SettingLink("Company Segments", "#", "bi-pie-chart"),
                new SettingLink("Gateway Keys", "#", "bi-key"),
                new SettingLink("Data Provider", "#", "bi-hdd-network"),
                new SettingLink("Notification Center", "#", "bi-bell"),
            }),
            new("Vehicle Maintenance", "azure", "Plan service cadences, warranties and component upgrades", new []
            {
                new SettingLink("Inventory", "#", "bi-box-seam"),
                new SettingLink("Work Orders", "#", "bi-clipboard-check"),
                new SettingLink("Service Level", "#", "bi-speedometer"),
                new SettingLink("Vendor Ledger", "#", "bi-receipt"),
            })
        };

        ViewData["Title"] = "Settings";
    }
}
