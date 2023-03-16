using Sikreys.Models.Message;
using Sikreys.Models.User;
using System.Collections.Generic;

namespace Sikreys.Models.Post;

/// <summary>
/// CommentsPost - контейнер хранения сообщений пользователей, закрепленных к Post
/// </summary>
public class CommentsPost
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
    public List<Message.Message>? Messages {get;set;} = new List<Message.Message>();
}
