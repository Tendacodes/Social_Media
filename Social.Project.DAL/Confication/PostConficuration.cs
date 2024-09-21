using ClassLıbrary1.Concrate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Social.Project.DAL.Confication;


public class PostConficuration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(p => p.Id);

        
        builder.HasOne(p => p.Users)
               .WithMany(u => u.Posts) 
               .HasForeignKey(p => p.UserId); 

        
        builder.HasMany(p => p.Comments)
               .WithOne(c => c.Posts) 
               .HasForeignKey(c => c.PostId); 

    }

}