using tweet_backend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace tweet_backend.Services
{
    public class MongoDBService
    {
        private readonly IMongoCollection<Users> _userCollection;
        public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _userCollection = database.GetCollection<Users>(mongoDBSettings.Value.CollectionName);
        }
        public async Task<List<Users>> GetAsync() {
            return await _userCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<bool> SignInUserAsync(UserCred userCred)
        {

        }
        //public async Task CreateAsync(Users user) { }
        //public async Task AddToPlaylistAsync(string id, string movieId) { }
        //public async Task DeleteAsync(string id) { }
    }
}
