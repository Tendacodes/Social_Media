using ClassLıbrary1.Abstract;


namespace ClassLıbrary1.Concrate;

public class Post : BaseEntity
{
    public int Id { get; set; }
    public string Text { get; set; }
    // public string CommentId { get; set; }

    public int LikeCount { get; set; }

    public int UserId { get; set; }


    //Navigation

    public virtual User Users { get; set; }

    public virtual ICollection<Comment> Comments { get; set; }
    //public virtual ICollection<Post> Posts { get; set; }
    public virtual Post Posts { get; set; }



}
