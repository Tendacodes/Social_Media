using ClassLıbrary1.Concrate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Social.Project.DAL.Confication;

public class UserDetailsConficuration : IEntityTypeConfiguration<UserDetails>
{
    public void Configure(EntityTypeBuilder<UserDetails> builder)
    {
        
        builder.HasKey(ud => ud.Id);

        
        builder.HasOne(ud => ud.User)
               .WithOne(u => u.UserDetails) 
               .HasForeignKey<User>(u => u.UserDetailsId); 
    }
}

