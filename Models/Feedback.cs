using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace FuelQ.Models
{
    public class Feedback

    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("starFeedback")]
        public string starFeedback { get; set; } = String.Empty;

        [BsonElement("userFeedback")]
        public string userFeedback { get; set; } = String.Empty;

        [BsonElement("station")]
        public string station { get; set; } = String.Empty;

    }

}
