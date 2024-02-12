using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models.Models.Masters
{
    public class ItemMasterModels:BaseEntiryModels
    {
        [Key]
        public Guid ItemID { get; set; }

        [Required(ErrorMessage = "Please Add ItemName")]
        public string? ItemName { get; set; }

        [Required(ErrorMessage = "Please Add ItemDescription")]
        public string? ItemDescription { get; set; }

        [Required(ErrorMessage = "Please Add MRP")]
        public decimal? MRP { get; set; }

        [Required(ErrorMessage = "Please Add SalesRate")]
        public decimal? SalesRate { get; set; }

        [Required(ErrorMessage = "Please Add CategoryID")]
        public Guid CategoryID { get; set; }

    }
}
