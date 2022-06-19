using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DB3GP.DAL.Entities
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Serial { get; set; }
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public string ItemStatus { get; set; } = "Free";

        [Range(1, Int32.MaxValue, ErrorMessage = "Value should be greater than or equal to 1")]
        public int Quantity { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Value should be greater than or equal to 1")]
        public int UnitPrice { get; set; }
        public string Popular { get; set; } = "False";

        //private string currdate = DateTime.Now.ToString();
        //private string futuredate = DateTime.Now.AddMonths(6).ToString();

        //[Range(typeof(DateTime), currdate, futuredate,
        //ErrorMessage = "Value for {0} must be between {1} and {2}")]

        //[Range(typeof(DateTime), "1/2/2004", "3/4/2004",
        //ErrorMessage = "Value for {0} must be between {1} and {2}")]

        public DateTime DateUpdated { get; set; }

        public string Image { get; set; }

        internal static object AddExist(string name, int qT)
        {
            throw new NotImplementedException();
        }
    }
}
