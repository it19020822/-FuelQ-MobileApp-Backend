namespace FuelQ.Models
{
    public interface ICustomerStoreDatabaseSettings
    {
        string CustomerCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
