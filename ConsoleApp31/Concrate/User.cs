using ClassLıbrary1.Abstract;

namespace ClassLıbrary1.Concrate;

public class User : BaseEntity
{
    public int Id { get; set; }
    public int UserDetailsId { get; set; }



    // Navigation Property
    public virtual ICollection<Post> Posts { get; set; }
    public UserDetails UserDetails { get; set; }



}