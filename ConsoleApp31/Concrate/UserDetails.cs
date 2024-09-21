using ClassLıbrary1.Abstract;

namespace ClassLıbrary1.Concrate;

public class UserDetails : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public DateTime Birtday { get; set; }

    public enum Role
    {

        User = 1,
        Admin = 2,

    }

    public virtual User User { get; set; }
}
