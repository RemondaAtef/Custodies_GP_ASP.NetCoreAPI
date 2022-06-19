using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.ViewModel
{
    public class getAllRequestsVM
    {
        public int ItemID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string ItemName { get; set; }
        public string RequestStatus { get; set; }

    }
}
