using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Entiry.Masters
{
    public class UnitMaster:BaseEntity
    {
        [Key]
        public Guid UnitID { get; set; }
        public string? UnitName { get; set; }
        public string? UnitDescription { get; set; }
    }
}
