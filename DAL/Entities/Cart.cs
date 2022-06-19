using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.Entities
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        public int CartID { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Member Member { get; set; }

        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }

        public int CartQuantity { get; set; } = 1;
    }
}
