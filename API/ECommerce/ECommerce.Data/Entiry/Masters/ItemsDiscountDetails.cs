using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Entiry.Masters
{
    public class ItemsDiscountDetails
    {
        [Key]
        public Guid ID { get; set; }
        public Guid ItemID { get; set; }
        public decimal DiscountQty { get; set; }
        public decimal DiscountPercentage { get; set; }
    }
}
