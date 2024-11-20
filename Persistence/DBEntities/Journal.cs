using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DBEntities
{
    internal class Journal
    {
        private string Journal_Name { get; set; } 
        public List<string> Subgect { get; set; }
        //public List<User> Students { get; set; } = new List<User>();
        public object Date = new DateTime();
        public Dictionary<Dictionary<List<User>, short>, DateTime > Marks { get; set; }
        public Dictionary<User, string> comment { get; set; }
    }


}
}
