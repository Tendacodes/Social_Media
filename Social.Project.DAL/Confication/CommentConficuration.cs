using ClassLıbrary1.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Social.Project.DAL.Confication;

public class CommentConficuration : IEntityTypeConfiguration<Comment>
{

    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(c => c.Id);


        builder.HasMany(c => c.Post)
               .WithMany(p => p.Comments);
               //.HasForeignKey(c => c.PostId) 
               //.OnDelete(DeleteBehavior.Cascade);


        //builder.HasOne(c => c.ParentComment)
        //       .WithMany(c => c.Replies)
        //       .HasForeignKey(c => c.ParentCommentId)
        //       .OnDelete(DeleteBehavior.Restrict);

    }



}
