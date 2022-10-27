namespace FuelQ.Models
{
    public class FuelStoreDatabaseSettings : IFuelStoreDatabaseSettings
    {
        public string FuelCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}
