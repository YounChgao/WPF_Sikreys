

namespace Sikreys.Models.User;

public class Profile
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string? Name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string? Description { get; set; }
    public Account? AccountId { get; set; }
    public int ImageId { get; set; }
    public Image? Avatar { get; set; }
}
