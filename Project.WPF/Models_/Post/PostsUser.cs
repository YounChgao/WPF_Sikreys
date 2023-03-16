using Sikreys.Models.User;
using System.Collections.Generic;

namespace Sikreys.Models.Post;

/// <summary>
///  PostsUser - контейнер хранения постов определенного пользователя
/// </summary>
public class PostsUser
{
    public int Id { get; set; }
    public int ProfileId { get; set; }
    public Profile? Owner { get; set; }
    public List<Post>? Posts { get; set; }
}
