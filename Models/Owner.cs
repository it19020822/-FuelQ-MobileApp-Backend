using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace FuelQ.Models
{
    public class Owner 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("ownerID")]
        public int OwnerId { get; set; } = 0;
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
        [BsonElement("ownerStationID")]
        public string OwnerStationID { get; set; } = String.Empty;
        [BsonElement("ownerLocation")]
        public string OwnerLocation { get; set; } = String.Empty;
        [BsonElement("ownerLitresArriving")]
        public int OwnerLitresArriving { get; set; } = 0;
        [BsonElement("ownerDateTime")]
        public string OwnerDateTime { get; set; } = String.Empty;
        [BsonElement("vehicleTypeTotal")]
        public int VehicleTypeTotal { get; set; } = 0;
    }
}
