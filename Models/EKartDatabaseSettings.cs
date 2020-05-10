using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ekart.Models
{
    public class EKartDatabaseSettings : IEKartDatabaseSettings
    {
        public string EKartCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IEKartDatabaseSettings
    {
        public string EKartCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
