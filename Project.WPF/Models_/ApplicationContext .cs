using Sikreys.Models.Message;
using Sikreys.Models.Post;
using Sikreys.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Sikreys.Models;

public class ApplicationContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<ProfileFriends> ProfileFriends { get; set; }


    public DbSet<Post.Post> Posts { get; set; }
    public DbSet<CommentsPost> CommentsPosts { get; set; }
    public DbSet<PostsUser> PostsUsers { get; set; }


    public DbSet<Message.Message> Messages { get; set; }
    public DbSet<DialogUsers> DialogsUsers { get; set; }

    public DbSet<Image> Images { get; set; }

    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
}
