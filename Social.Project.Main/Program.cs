using ClassLıbrary1.Concrate;
using Social.Project.DAL.Context;
using Social.Project.DAL.Repository.Concrate;

namespace Social.Project.Main;



public class Program
{

    static void Main(string[] args)
    {
        UserDetailsRepository userDetailsRepository = new UserDetailsRepository();
        UserRepository userRepository = new UserRepository();
        PostRepository postRepository = new PostRepository();
        CommentRepository commentRepository = new CommentRepository();



        UserDetails user_INFO_1 = new UserDetails()
        {
            Name = "Ehmed",
            Surname = "Tofiqov",
            Birtday = DateTime.Now,
            UserRole = UserDetails.Role.Admin
        };


        User user1 = new User()
        {
            UserDetailsId = 1
        };



        Post post1 = new Post()
        {
            Text = "Salam Salam",
            Comment = "Sassdadadadasdadad",
            UserId = 1,
        };


        userDetailsRepository.Add(user_INFO_1);
        userRepository.Add(user1);
        postRepository.Add(post1);
        

        userDetailsRepository.SaveChanges();
        userRepository.SaveChanges();
        postRepository.SaveChanges();
        commentRepository.SaveChanges();

    }

}
