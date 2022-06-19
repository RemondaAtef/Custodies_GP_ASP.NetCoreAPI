using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.ViewModel
{
    public class getAllUsersVM
    {
       // public string UserId { get; set; }
                
        public string Name { get; set; }

        public string Email { get; set; }

        public MemberStatus status { get; set; }

        // public string status { get; set; }
    }
    public enum MemberStatus
    {
        Active = 1,
        Inactive = 2,
    }
}
