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
        public string CustomerVehicleNumber { get; set; } = String.Empty;

        [BsonElement("customerVehicleType")]
        public string CustomerVehicleType { get; set; } = String.Empty;
        
        [BsonElement("customerFuelType")]
        public string CustomerFuelType { get; set; } = String.Empty;

        [BsonElement("awaitingTime")]
        public string AwaitingTime { get; set; } = String.Empty;

        [BsonElement("token")]
        public string Token { get; set; } = String.Empty;

        [BsonElement("arrivalTimeQ")]
        public string ArrivalTimeQ { get; set; } = String.Empty;

        [BsonElement("departTimeQ")]
        public string DepartTimeQ { get; set; } = String.Empty;

        [BsonElement("requestedLitres")]
        public string RequestedLitres { get; set; } = String.Empty;

        [BsonElement("rating")]
        public string Rating { get; set; } = String.Empty;
    }
}
