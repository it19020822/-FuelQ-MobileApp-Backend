namespace FuelQ.Models
{
    public class CustomerStoreDatabaseSettings : ICustomerStoreDatabaseSettings
    {
        public string CustomerCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}
