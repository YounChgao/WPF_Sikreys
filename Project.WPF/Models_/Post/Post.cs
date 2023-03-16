using Sikreys.Models.User;
using System.Collections.Generic;

namespace Sikreys.Models.Post;

public class Post
{
    public int Id { get; set; }
    public int Text { get; set; }
    public int ProfileId { get; set; }
    public Profile? Owner { get; set; }
    public List<Image>? Images { get; set; } = new List<Image>();

    /// <summary>
    /// ProfilesLike - свойство, хранящие людей понравишимся пост
    /// </summary>
    public List<Profile>? ProfilesLike {get; set;} = new List<Profile>();

}
