using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DBEntities
{
    internal class Subjects
    {
        public string Subjects_Name { get; set; }
        public Teachers Teacher { get; set; } = new Teachers();
        public List<Journal> Subjects_Journal { get; set; } = new List<Journal>();

    }
}
