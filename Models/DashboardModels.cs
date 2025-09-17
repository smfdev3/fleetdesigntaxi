namespace FleetDesignTaxi.Models;

public record TransactionRecord(string Route, int Trips, int Completed, int Cancelled, decimal Revenue);

public record SmsAlert(string Recipient, string Category, string Message, string Status, DateTime SentAt);

public record NewsItem(string Title, string Category, DateTime PublishedOn, string Summary, string Link);

public record RevenuePoint(DateTime Date, decimal Amount);
