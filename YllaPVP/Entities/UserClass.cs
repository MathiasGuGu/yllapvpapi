namespace YllaPVP.Entities;

public class UserClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Level { get; set; }
    public List<User> User { get; set; }
}