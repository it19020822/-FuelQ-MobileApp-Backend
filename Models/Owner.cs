/*
  -------------------
     OWNER MODEL
  -------------------
*/

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace FuelQ.Models
{
    public class Owner 

    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("ownerName")]
        public string OwnerName { get; set; } = String.Empty;
        [BsonElement("ownerEmail")]
        public string OwnerEmail { get; set; } = String.Empty;
        [BsonElement("ownerPassword")]
        public string OwnerPassword { get; set; } = String.Empty;
        [BsonElement("ownerContact")]
        public string OwnerContact { get; set; } = String.Empty;
        [BsonElement("ownerFuelStation")]
        public string OwnerFuelStation { get; set; } = String.Empty;
        [BsonElement("ownerLocation")]
        public string OwnerLocation { get; set; } = String.Empty;
    }

}
