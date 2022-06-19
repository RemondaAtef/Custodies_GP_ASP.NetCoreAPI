using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.Entities
{
    [Table("OwnerShip")]
    public class OwnerShip
    {
        [Key]
        public int OwnerShipID { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Member Member { get; set; }

        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }

        public int OwnerShipQuantity { get; set; }
        public DateTime OwnershipDate { get; set; }
   
    }
}
