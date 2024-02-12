using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models.Models.Masters
{
    public class DepartmentMasterModels : BaseEntiryModels
    {
        [Key]
        public Guid DeptID { get; set; }

        [Required(ErrorMessage = "Please Add DepartmentName")]
        public string? DepartmentName { get; set; }
    }
}
