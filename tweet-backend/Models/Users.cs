using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tweet_backend.Models
{
    public class Users
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("username")]
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [BsonElement("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [BsonElement("bio")]
        [JsonPropertyName("bio")]
        public string Bio { get; set; }
        [BsonElement("followers")]
        [JsonPropertyName("followers")]
        public int Followers { get; set; }
        [BsonElement("following")]
        [JsonPropertyName("following")]
        public int Following { get; set; }
        [BsonElement("tweets")]
        [JsonPropertyName("tweets")]
        public List<Tweets> Tweets { get; set; }

    }

    public class Tweets
    {
        [BsonElement("date")]
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [BsonElement("tweet")]
        [JsonPropertyName("tweet")]
        public string Tweet { get; set; }

    }
}
