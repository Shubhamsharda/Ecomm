using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekart.Models
{
    public class Category
    {
        [BsonElement("main")]
        public string main { get; set; }
        [BsonElement("sub")]
        public string sub { get; set; }
    }
}
