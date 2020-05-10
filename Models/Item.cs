using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekart.Models
{
    public class Item
    {
        public int id { get; set; }
        public string itemName { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        //public Reviews MyProperty { get; set; }
    }
}
