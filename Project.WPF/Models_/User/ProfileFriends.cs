using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sikreys.Models.User;

public class ProfileFriends
{
    public int Id { get; set; }
    public int ProfileId { get; set; }
    public Profile? Owner { get; set; }
    public List<Profile>? Friends { get; set; }


}
