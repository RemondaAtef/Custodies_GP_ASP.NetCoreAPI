using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.ViewModel
{
    public class ViewDetailsVM
    {
        public string Serial { get; set; }
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public string ItemStatus { get; set; } 
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}
