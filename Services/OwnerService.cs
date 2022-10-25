/*
  ---------------------
   SHED OWNER SERVICE
  ---------------------
*/

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

        //Create Shed Owner
        public Owner Create(Owner owner)
        {
             _owners.InsertOne(owner);
            return owner;
        }

        //Get All Shed Owners
        public List<Owner> Get()
        {
            return  _owners.Find(owner => true).ToList();
        }

        //Get Shed Owner by ID
        public Owner Get(string id)
        {
            return  _owners.Find(owner => owner.Id == id).FirstOrDefault();
        }

        //Get Shed Owner by Email
        public Owner GetByEmail(string email)
        {
            return _owners.Find(owner => owner.OwnerEmail == email).FirstOrDefault();
        }

        //Remove Shed Owner by ID
        public void Remove(string id)
        {
             _owners.DeleteOne(owner => owner.Id == id);
        }

        //Update Shed Owner by id
        public void Update(string id, Owner owner)
        {
             _owners.ReplaceOne(owner => owner.Id == id, owner);
        }
    }
}
