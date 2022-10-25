using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace FuelQ.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

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

        [BsonElement("awaitingTime")]
        public string AwaitingTime { get; set; } = String.Empty;

        [BsonElement("token")]
        public int Token { get; set; } = 0;

        [BsonElement("arrivalTimeQ")]
        public string ArrivalTimeQ { get; set; } = String.Empty;

        [BsonElement("departTimeQ")]
        public string DepartTimeQ { get; set; } = String.Empty;

        [BsonElement("requestedLitres")]
        public int RequestedLitres { get; set; } = 0;
    }
}
