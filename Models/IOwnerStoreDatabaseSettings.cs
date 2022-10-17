namespace FuelQ.Models
{
    public interface IOwnerStoreDatabaseSettings
    {
        string OwnerCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
