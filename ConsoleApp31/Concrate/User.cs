using ClassLıbrary1.Abstract;

namespace ClassLıbrary1.Concrate;

public class User : BaseEntity
{
    public int Id { get; set; }
    public int UserDetailsId { get; set; }



    // Navigation Property
    public UserDetails UserDetails { get; set; }
    public  ICollection<Post> Post { get; set; }
   



}