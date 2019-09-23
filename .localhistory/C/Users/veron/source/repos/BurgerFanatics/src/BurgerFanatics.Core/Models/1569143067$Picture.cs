using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Models
{
    public class Picture : FullAuditedEntity
    {
        public String FileName { get; set; }

        public String FileContentType { get; set; }
    }
}
