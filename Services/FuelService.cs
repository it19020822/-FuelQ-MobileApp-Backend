using FuelQ.Models;
using MongoDB.Driver;

namespace FuelQ.Services
{
    public class FuelService : IFuelService
    {
        private readonly IMongoCollection<Fuel> _fuels;

        public FuelService(IFuelStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _fuels = database.GetCollection<Fuel>(settings.FuelCollectionName);
        }


        public Fuel Create(Fuel fuel)
        {
            _fuels.InsertOne(fuel);
            return fuel;
        }

        public List<Fuel> Get()
        {
            return _fuels.Find(fuel => true).ToList();
        }

        public Fuel GetById(string id)
        {
            return _fuels.Find(fuel => fuel.Id == id).FirstOrDefault();
        }

        public List<Fuel> GetFuelByOwnerEmail(string ownerEmail)
        {
            return _fuels.Find(fuel => fuel.ownerEmail == ownerEmail).ToList();
        }

        public void Remove(string id)
        {
            _fuels.DeleteOne(fuel => fuel.Id == id);
        }

        public void Update(string id, Fuel fuel)
        {
            _fuels.ReplaceOne(fuel => fuel.Id == id, fuel);
        }
    }
}
