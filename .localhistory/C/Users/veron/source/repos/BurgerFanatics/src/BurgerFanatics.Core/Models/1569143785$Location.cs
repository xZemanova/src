using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Models
{
    public class Location : FullAuditedEntity
    {
        public String Name { get; set; }

        public String Address { get; set; }

        public float Lat { get; set; }

        public float Lng { get; set; }

        public String type { get; set; }
    }
}
