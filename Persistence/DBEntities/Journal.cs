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
        // Было решено сделать универсальную сущность журнала, и в контексте сделать под каждый тип журнала отдельный(через Ignore c FluentAPI)

        private string Journal_Name { get; set; }
        public bool Type_Of_Journak { get; set; } // true - для студента false для препода
        public List<string> Subgect { get; set; } // список предметов журнала для студента
        public object Date = new DateTime(); // дата оценки
        public Dictionary<Dictionary<List<User>, short>, DateTime > Marks { get; set; } // сама оценка которая вяэется к журналу и дате
        public Dictionary<User, string> comment { get; set; }
    }


}

