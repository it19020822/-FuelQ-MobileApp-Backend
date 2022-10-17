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
        [BsonElement("customerEmail")]
        public string CustomerEmail { get; set; } = String.Empty;
        [BsonElement("customerPassword")]
        public string CustomerPassword { get; set; } = String.Empty;
        [BsonElement("customerVehicleNumber")]
        public int CustomerVehicleNumber { get; set; } = 0;
        [BsonElement("customerVehicleType")]
        public string CustomerVehicleType { get; set; } = String.Empty;
        [BsonElement("customerFuelType")]
        public string CustomerFuelType { get; set; } = String.Empty;
    }
}
