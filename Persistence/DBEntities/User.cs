using System.Diagnostics.Contracts;

namespace Persistence.DBEntities;



    public class User
    {
        // Универсаьный юзер с разными правами доступа вместо преподоа и студента
        public int Guid { get; private set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int acsess_level { get; set; }
        public int Hash_Password { get; private set; }



    }

