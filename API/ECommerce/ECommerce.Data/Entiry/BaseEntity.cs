using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Entiry
{
    public class BaseEntity
    {
        public DateTime ADate { get; set; }
        public DateTime MDate { get; set; }
        public int DeleteFlag { get; set; }
        public Guid UserID { get; set; }
        public Guid OrgID { get; set; }
    }
}
