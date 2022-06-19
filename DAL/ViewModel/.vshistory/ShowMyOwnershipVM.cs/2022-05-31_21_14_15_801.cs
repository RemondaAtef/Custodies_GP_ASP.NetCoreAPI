using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.ViewModel
{
    public class ShowMyOwnershipVM
    {
        [Key]
        public int ownershipid { get; set; }
        public string ItemName { get; set; }
        public DateTime Date { get; set; }
    }
}
