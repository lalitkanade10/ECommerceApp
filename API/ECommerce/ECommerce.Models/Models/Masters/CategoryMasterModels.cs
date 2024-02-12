using ECommerce.Data.Entiry.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models.Models.Masters
{
    public class CategoryMasterModels : DepartmentMaster
    {
        [Key]
        public Guid CategoryID { get; set; }

        [Required(ErrorMessage = "Please Add CategoryName")]
        public string? CategoryName { get; set; }

        [Required(ErrorMessage = "Please Add DeptID")]
        public Guid DeptID { get; set; }
    }
}
