

namespace ClassLıbrary1.Concrate;

public class Comment
{
    public object Posts;

    public int Id { get; set; }
    public string Text { get; set; }


    // Foreign Key 
    
    public  ICollection<Post> Post {  get; set; }

   

    
    //public int ParentCommentId { get; set; }
    //public virtual Comment ParentComment { get; set; } 
    
    //public virtual ICollection<Comment> Replies { get; set; }


    //public Comment()
    //{
    //    Replies = new HashSet<Comment>();
    //}
}
