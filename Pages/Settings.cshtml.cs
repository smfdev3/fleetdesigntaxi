using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FleetDesignTaxi.Pages;

public class SettingsModel : PageModel
{
    public record SettingSection(string Title, string Accent, string Description, IEnumerable<SettingLink> Links);
    public record SettingLink(string Label, string Url, string Icon);

    public IReadOnlyList<SettingSection> Sections { get; private set; } = Array.Empty<SettingSection>();

    public void OnGet()
    {
        Sections = new List<SettingSection>
        {
            new("Vehicle Setting", "azure", "Manage fleet vehicle archetypes, classes and telematics tags", new []
            {
                new SettingLink("Vehicle Types", "#", "car"),
                new SettingLink("Taxi Tags", "#", "bookmark"),
                new SettingLink("Vehicle Group", "#", "group"),
                new SettingLink("Driver Pool", "#", "user"),
                new SettingLink("Employee Card", "#", "idcard")
            }),
            new("Accident Setting", "amber", "Standardize emergency protocols and field reporting flows", new []
            {
                new SettingLink("Police Protocol", "#", "warning"),
                new SettingLink("Claim Forms", "#", "description"),
                new SettingLink("Incident Templates", "#", "doc"),
                new SettingLink("Response Contacts", "#", "tel"),
            }),
            new("General Setting", "emerald", "Organization-wide tax, billing and integration preferences", new []
            {
                new SettingLink("Company Segments", "#", "chart"),
                new SettingLink("Gateway Keys", "#", "key"),
                new SettingLink("Data Provider", "#", "database"),
                new SettingLink("Notification Center", "#", "bell"),
            }),
            new("Vehicle Maintenance", "azure", "Plan service cadences, warranties and component upgrades", new []
            {
                new SettingLink("Inventory", "#", "box"),
                new SettingLink("Work Orders", "#", "task"),
                new SettingLink("Service Level", "#", "speed"),
                new SettingLink("Vendor Ledger", "#", "card"),
            })
        };

        ViewData["Title"] = "Settings";
    }
}
