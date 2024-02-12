using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Entiry.Masters
{
    public class DepartmentMaster:BaseEntity
    {
        [Key]
        public Guid DeptID { get; set; }
        public string? DepartmentName { get; set; }
    }
}
