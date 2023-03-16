using Sikreys.Models;
using Sikreys.Models.User;
using System.Collections.Generic;

namespace Sikreys.Models.Message;

/// <summary>
/// ContainerMessage - представления контейнера сообщений, к которому должено пренадлежить сообщение
/// </summary>
public enum ContainerMessage
{
    //DialogUsers - Чат пользователей
    DialogUsers, 
    //CommentsPost - Контейнер комментариев к посту
    CommentsPost 
}


/// <summary>
/// Класс представления сообщения от пользователя
/// </summary>
public class Message
{
    public int Id { get; set; }
    public int Text { get; set; }
    public Profile? Owner { get; set; }
    public int ProfileId { get; set; }
    public int ImageId { get; set; }
    public List<Image>? Images { get; set; }

    /// <summary>
    /// Container - представления контейнера, к которому сообщение пренадлежит
    /// </summary>

    public ContainerMessage Container { get; set; }
    public int ContainerId { get; set; }

}
