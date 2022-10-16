using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace FuelQ.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("userId")]
        public int UserId { get; set; } = 0;
        [BsonElement("vehicleType")]
        public string VehicleType { get; set; } = String.Empty;
        [BsonElement("fuelType")]
        public string FuelType { get; set; } = String.Empty;
        [BsonElement("fuelVol")]
        public int FuellVol { get; set; } = 0;
        public DateTime DateTime { get; set; } = DateTime.Now;

    }
}
