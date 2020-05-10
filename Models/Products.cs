using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ekart.Models
{
    public class Products
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("manufacturer")]
        public string Manufacturer { get; set; }

        [BsonElement("price")]
        public int Price { get  ; set; }

        [BsonElement("display")]
        public string Display{ get; set; }

        [BsonElement("model")]
        public string Model { get; set; }

        [BsonElement("categories")]
        public Category Categories { get; set; }
        [BsonElement("android")]
        public string android { get; set; }
        [BsonElement("battery")]
        public double battery { get; set; }

        [BsonElement("ram")]
        public string ram { get; set; }

        [BsonElement("camera")]

        public string Camera { get; set; }

        [BsonElement("material")]

        public string material { get; set; }

        [BsonElement("processor")]

        public string processor { get; set; }

        [BsonElement("memory")]

        public string memory { get; set; }



    }
}
