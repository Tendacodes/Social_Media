using ClassLıbrary1.Concrate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Social.Project.DAL.Confication;


public class UserConficuration : IEntityTypeConfiguration<User>
{

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);

       
        builder.HasOne(u => u.UserDetails)
               .WithOne(ud => ud.User) 
               .HasForeignKey<User>(u => u.UserDetailsId); 

        
        builder.HasMany(u => u.Posts)
               .WithOne(p => p.Users) 
               .HasForeignKey(p => p.UserId); 

    }

}


