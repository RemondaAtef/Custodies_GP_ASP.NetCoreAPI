using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.Entities
{
    [Table("Request")]
    public class Request
    {
        [Key]
        public int RequestID { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Member Member { get; set; }

        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
 
        public string RequestStatus { get; set; } = "waiting";

        public int RequestQuantity { get; set; }

        public string TakeOrRestore { get; set; }

        public string StatusAfterRestore { get; set; }

        // public string Date { get; set; }
    }
}

