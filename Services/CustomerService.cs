/*
  ---------------------
     CUSTOMER SERVICE
  ---------------------
*/

using FuelQ.Models;
using MongoDB.Driver;

namespace FuelQ.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IMongoCollection<Customer> _customers;
        public CustomerService(ICustomerStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var databse = mongoClient.GetDatabase(settings.DatabaseName);
            _customers = databse.GetCollection<Customer>(settings.CustomerCollectionName);
        }

        //Create Customer
        public Customer Create(Customer customer)
        {
            _customers.InsertOne(customer);
            return customer;
        }

        //Get All Customers
        public List<Customer> Get()
        {
            return _customers.Find(customer => true).ToList();
        }

        //Get Customer by ID
        public Customer Get(string id)
        {
            return _customers.Find(customer => customer.Id == id).FirstOrDefault();
        }

        public List<Customer> GetByShedName(string shedName)
        {
            return _customers.Find(customer => customer.ShedQ == shedName).ToList();
        }

        //Remove Customer by ID
        public void Remove(string id)
        {
            _customers.DeleteOne(customer => customer.Id == id);
        }

        //Update Customer by ID
        public void Update(string id, Customer customer)
        {
            _customers.ReplaceOne(customer => customer.Id == id, customer);
        }
    }
}
