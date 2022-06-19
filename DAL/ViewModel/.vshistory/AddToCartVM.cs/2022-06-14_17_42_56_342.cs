using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.ViewModel
{
    public class AddToCartVM
    {
        public int CartID { get; set; }
        public string UserId { get; set; }
        public int ItemId { get; set; }
        public int Quantityy { get; set; } = 1;
      //  public string itemName { get; set; }
    }
}
