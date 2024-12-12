using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DBEntities
{
    internal class Students
    {
        public string Student_Name { get; set; }
        public int Studen_Age { get; set; }
        public Group Student_Group { get; set; } = new Group();
        public List<Journal> Journal_List { get; set; } = new List<Journal>();
    }
}
