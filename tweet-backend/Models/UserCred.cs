using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tweet_backend.Models
{
    public class UserCred
    {
        [BsonElement("username")]
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [BsonElement("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
