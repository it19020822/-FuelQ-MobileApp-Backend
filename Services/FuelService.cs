/*
  ---------------------
       FUEL SERVICE
  ---------------------
*/

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

        //Create Fuel
        public Fuel Create(Fuel fuel)
        {
            _fuels.InsertOne(fuel);
            return fuel;
        }

        //Get All Fuel Details
        public List<Fuel> Get()
        {
            return _fuels.Find(fuel => true).ToList();
        }

        //Get Fuel by ID
        public Fuel GetById(string id)
        {
            return _fuels.Find(fuel => fuel.Id == id).FirstOrDefault();
        }

        public List<Fuel> GetByStation(string station)
        {
            return _fuels.Find(fuel => fuel.fuelStation == station).ToList();
        }

        //Remove Fuel by ID
        public void Remove(string id)
        {
            _fuels.DeleteOne(fuel => fuel.Id == id);
        }

        //Update Fuel by ID
        public void Update(string id, Fuel fuel)
        {
            _fuels.ReplaceOne(fuel => fuel.Id == id, fuel);
        }
    }
}
