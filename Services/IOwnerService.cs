using FuelQ.Models;

namespace FuelQ.Services
{
    public interface IOwnerService
    {
        List<Owner> Get();
        Owner Get(string id);
        Owner GetByEmail(string email);
        Owner Create(Owner owner);
        void Update(string id, Owner owner);
        void Remove(string id);
    }
}
