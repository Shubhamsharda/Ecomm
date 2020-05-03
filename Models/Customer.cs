using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ekart.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string phoneNumber { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string email { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string userName { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string password { get; set; }
    }
}
