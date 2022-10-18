namespace FuelQ.Models
{
    public class OwnerStoreDatabaseSettings : IOwnerStoreDatabaseSettings
    {
        public string OwnerCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}
