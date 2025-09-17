namespace FleetDesignTaxi.Models;

public record AutoServiceEntry(
    string Vendor,
    string ServiceType,
    string Vehicle,
    string Registration,
    string Contact,
    string Email,
    string Status,
    DateTime LastService,
    DateTime NextService,
    decimal Cost
);
