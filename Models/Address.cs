using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ekart.Models
{
    public class Address
    {
        [BsonElement("state")]
        public string state { get; set; }
        [BsonElement("city")]
        public string city { get; set; }
        [BsonElement("zip")]
        public string zip{ get; set; }
        [BsonElement("landmark")]
        public string landmark { get; set; }
    }
}
