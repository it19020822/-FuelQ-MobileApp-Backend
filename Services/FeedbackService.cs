using FuelQ.Models;
using MongoDB.Driver;

namespace FuelQ.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IMongoCollection<Feedback> _feedbacks;

        public FeedbackService(IFeedbackStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _feedbacks = database.GetCollection<Feedback>(settings.FeedbackCollectionName);
        }


        public Feedback Create(Feedback feedback)
        {
            _feedbacks.InsertOne(feedback);
            return feedback;
        }

        public List<Feedback> Get()
        {
            return _feedbacks.Find(feedback => true).ToList();
        }

        public Feedback GetById(string id)
        {
            return _feedbacks.Find(feedback => feedback.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _feedbacks.DeleteOne(feedback => feedback.Id == id);
        }

        public void Update(string id, Feedback feedback)
        {
            _feedbacks.ReplaceOne(feedback => feedback.Id == id, feedback);
        }
    }
}
