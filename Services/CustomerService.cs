using Ekart.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekart.Services
{
    public class CustomerService
    {
        private readonly IMongoCollection<Customers> _customers;

        public CustomerService(IEKartDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _customers = database.GetCollection<Customers>(settings.EKartCollectionCustomers);
        }

        public List<Customers> Get() =>
            _customers.Find(customer => true).ToList();

        public Customers Get(string id) =>
            _customers.Find<Customers>(customer => customer.Id == id).FirstOrDefault();

        public Customers Create(Customers customer)
        {
            _customers.InsertOne(customer);
            return customer;
        }

        public void Update(string id, Customers customerIn) =>
            _customers.ReplaceOne(customer => customer.Id == id, customerIn);

        public void Remove(string id) =>
            _customers.DeleteOne(customer => customer.Id == id);
    }
}
