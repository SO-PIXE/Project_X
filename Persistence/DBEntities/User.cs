namespace Persistence.DBEntities;

public class User
{
    public int Guid { get; private set; }
    public string Name { get; set; }
    public string Group { get; set; }
    public int acsess_level { get; set; }

    

}
