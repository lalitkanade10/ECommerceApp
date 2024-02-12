using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models.Models
{
    public class BaseEntiryModels
    {
        public DateTime ADate { get; set; }
        public DateTime MDate { get; set; }
        public int DeleteFlag { get; set; }
        public Guid UserID { get; set; }
        public Guid OrgID { get; set; }
    }
}
