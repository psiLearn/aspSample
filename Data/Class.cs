using MongoDB.Driver;

namespace aspSample.Data
{
    public class CustomerDataContext
    {
        private readonly IMongoDatabase _database;
        public CustomerDataContext()
        {
            var connectingString = "mongodb://mongodb:27017";
            var mongoClient = new MongoClient(connectingString);
            _database = mongoClient.GetDatabase("AspNetSample");
        }
        public IMongoCollection<Customer> Customers => _database.GetCollection<Customer>("Customer");
    }
}
