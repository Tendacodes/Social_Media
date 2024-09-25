using ClassLıbrary1.Concrate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Social.Project.DAL.Confication;


public class PostConficuration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(p => p.Id);

        
        builder.HasOne(p => p.User)
               .WithMany(u => u.Post) 
               .HasForeignKey(p => p.UserId);


        builder.HasMany(p => p.Comments)
               .WithMany(c => c.Post); 
               //.HasForeignKey(c => c.PostId); 

    }

}