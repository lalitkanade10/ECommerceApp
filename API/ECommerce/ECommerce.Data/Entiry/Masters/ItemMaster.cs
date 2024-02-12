using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Entiry.Masters
{
    public class ItemMaster:BaseEntity
    {
        [Key]
        public Guid ItemID { get; set; }
        public string? ItemName { get; set; }
        public string? ItemDescription { get; set; }
        public decimal? MRP { get; set; }
        public decimal? SalesRate { get; set; }
        public Guid CategoryID { get; set; }
    }
}
