using Sikreys.Models.User;
using System.Collections.Generic;

namespace Sikreys.Models.Message;

/// <summary>
/// Общий чат пользователей от одного до более людей
/// </summary>
public class DialogUsers
{
    public int Id { get; set; }
    public List<Profile>? Profiles { get; set; } = new List<Profile>();
    public List<Message>? Messages { get; set; } = new List<Message>();
}
