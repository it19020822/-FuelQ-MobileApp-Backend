namespace FuelQ.Models
{
    public interface IFeedbackStoreDatabaseSettings
    {
        string FeedbackCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
