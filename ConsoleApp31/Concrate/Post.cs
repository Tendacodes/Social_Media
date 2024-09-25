using ClassLıbrary1.Abstract;


namespace ClassLıbrary1.Concrate;

public class Post : BaseEntity
{
    public int Id { get; set; }
    public string Text { get; set; }
    
    public int LikeCount { get; set; }

    public int UserId { get; set; }

    //Navigation
    public  User User { get; set; }

    public  ICollection<Comment> Comments { get; set; }

   



}
