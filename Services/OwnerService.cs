using FuelQ.Models;
using MongoDB.Driver;

namespace FuelQ.Services
{
    public class OwnerService : IOwnerService
    {
        private readonly IMongoCollection<Owner> _owners;
        public OwnerService(IOwnerStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var databse = mongoClient.GetDatabase(settings.DatabaseName);
             _owners = databse.GetCollection<Owner>(settings.OwnerCollectionName);
        }
        public Owner Create(Owner owner)
        {
             _owners.InsertOne(owner);
            return owner;
        }

        public List<Owner> Get()
        {
            return  _owners.Find(owner => true).ToList();
        }

        public Owner Get(string id)
        {
            return  _owners.Find(owner => owner.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
             _owners.DeleteOne(owner => owner.Id == id);
        }

        public void Update(string id, Owner owner)
        {
             _owners.ReplaceOne(owner => owner.Id == id, owner);
        }
    }
}
