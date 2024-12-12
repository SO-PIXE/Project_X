using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DBEntities
{
    internal class Marks
    {
        public int Mark { get; set; }
        public string Mark_Comment { get; set; }
        public List<Journal> Mark_Journal { get; set; } = new List<Journal>();
    }
}
