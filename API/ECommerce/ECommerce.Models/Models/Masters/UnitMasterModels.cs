using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models.Models.Masters
{
    public class UnitMasterModels:BaseEntiryModels
    {
        [Key]
        public Guid UnitID { get; set; }

        [Required(ErrorMessage = "Please Add UnitName")]
        public string? UnitName { get; set; }

        [Required(ErrorMessage = "Please Add UnitDescription")]
        public string? UnitDescription { get; set; }
    }
}
