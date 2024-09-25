using Social.Project.DAL.Context;
using Social.Project.DAL.Repository.Concrate;

namespace Social.Project.Main;


public class UnitOfWork
{
    private readonly SocialDbContext _context;

    public UnitOfWork(SocialDbContext context, UserDetailsRepository userDetailsRepository, UserRepository userRepository, PostRepository postRepository, CommentRepository commentRepository)
    {
        _context = context;
        UserDetailsRepository = userDetailsRepository;
        UserRepository = userRepository;
        PostRepository = postRepository;
        CommentRepository = commentRepository;
    }

    public UserDetailsRepository UserDetailsRepository { get; set; }
    public UserRepository UserRepository { get; set; }
    public PostRepository PostRepository { get; set; }
    public CommentRepository CommentRepository { get; set; }
}