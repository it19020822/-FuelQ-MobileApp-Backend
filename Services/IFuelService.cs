using FuelQ.Models;

namespace FuelQ.Services
{
    public interface IFuelService
    {
        List<Fuel> Get();
        Fuel GetById(string id);
        Fuel Create(Fuel fuel);
        void Update(string id, Fuel fuel);
        void Remove(string id);
        List<Fuel> GetByStation(string station);
    }
}
