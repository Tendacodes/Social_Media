
using ClassLıbrary1.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Social.Project.DAL.Confication;

namespace Social.Project.DAL.Context;



public class SocialDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }

    public DbSet<Comment> Comments { get; set; }

    public DbSet<UserDetails> UsersDetailes { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=TENDA-NI; Initial Catalog = Social; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfiguration(new UserConficuration());
        modelBuilder.ApplyConfiguration(new  PostConficuration());
        modelBuilder.ApplyConfiguration(new  CommentConficuration());
        modelBuilder.ApplyConfiguration(new UserConficuration());

        base.OnModelCreating(modelBuilder);
    }









}


