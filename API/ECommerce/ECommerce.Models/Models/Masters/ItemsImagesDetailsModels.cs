using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models.Models.Masters
{
    public class ItemsImagesDetailsModels
    {
        [Key]
        public Guid ID { get; set; }

        [Required(ErrorMessage = "Please Add ItemID")]
        public Guid ItemID { get; set; }

        [Required(ErrorMessage = "Please Add ImagesName")]
        public string? ImagesName { get; set; }
    }
}
