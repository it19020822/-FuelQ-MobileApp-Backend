using FuelQ.Models;

namespace FuelQ.Services
{
    public interface IFeedbackService
    {
        List<Feedback> Get();
        Feedback GetById(string id);
        Feedback Create(Feedback feedback);
        void Update(string id, Feedback feedback);
        void Remove(string id);
    }
}
