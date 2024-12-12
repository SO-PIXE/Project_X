using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DBEntities
{
    internal class Group
    {
        public string group_name { get; set; }
        public int year_input { get; set; }
        public bool type_of_education { get; set; }
    }
}
