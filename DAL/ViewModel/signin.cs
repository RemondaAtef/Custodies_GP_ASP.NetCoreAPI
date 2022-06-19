using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.ViewModel
{
    public class signin
    {
        public string email { get; set; }
        public string Password { get; set; }

        public IEnumerable<ItemNamePhoto> Popular{get; set;}

    }
}
