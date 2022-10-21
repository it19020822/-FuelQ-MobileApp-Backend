using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace FuelQ.Models
{
    public class Fuel

    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("fuelType")]
        public string fuelType { get; set; } = String.Empty;

        [BsonElement("fuelStation")]
        public string fuelStation { get; set; } = String.Empty;

        [BsonElement("date")]
        public string date { get; set; } = String.Empty;

        [BsonElement("arrivingTime")]
        public string arrivingTime { get; set; } = String.Empty;

        [BsonElement("arrivedLitres")]
        public string arrivedLitres { get; set; } = String.Empty;

        [BsonElement("remainLitres")]
        public string remainLitres { get; set; } = String.Empty;
    }

}
