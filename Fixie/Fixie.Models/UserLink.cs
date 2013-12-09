using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fixie.Models
{
    public class UserLink
    {
        public User User { get; set; }
        public UserLinkType LinkType { get; set; }
    }
}
