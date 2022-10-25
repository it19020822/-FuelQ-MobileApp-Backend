namespace FuelQ.Models
{
    public class FeedbackStoreDatabaseSettings : IFeedbackStoreDatabaseSettings
    {
        public string FeedbackCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}
