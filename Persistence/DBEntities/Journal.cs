using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DBEntities
{
    internal class Journal
    {
        public List<Students> Journal_Students { get; set; } = new List<Students>();
        public List<Marks> Journal_Marks { get; set; } = new List<Marks>();
        public List<Subjects> JournalSubject { get; set; } = new List<Subjects>();
    }
}
