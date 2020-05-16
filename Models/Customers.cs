using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ekart.Models
{
    public class Customers
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("firstname")]
        public string firstName { get; set; }
        [BsonElement("lastname")]
        public string lastName { get; set; }
        [BsonElement("age")]
        public string age { get; set; }
        [BsonElement("address")]
        public Addresses address { get; set; }
    }
}
