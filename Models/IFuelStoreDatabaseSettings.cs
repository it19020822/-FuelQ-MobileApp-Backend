namespace FuelQ.Models
{
    public interface IFuelStoreDatabaseSettings
    {
        string FuelCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
