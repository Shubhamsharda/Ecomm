using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ekart.Models
{
    public class Addresses
    {
        [BsonElement("address1")]
        public Address address1 { get; set; }

        [BsonElement("address2")]
        public Address address2 { get; set; }

        [BsonElement("address3")]
        public Address address3 { get; set; }

    }
}
