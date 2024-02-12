using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Entiry.Masters
{
    public class CategoryMaster: BaseEntity
    {
        [Key]
        public Guid CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public Guid DeptID { get; set; }
    }
}
