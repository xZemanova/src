using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Models
{
    public class Picture : FullAuditedEntity
    {
        [Required]
        public String FileName { get; set; }

        [Required]
        public String FileContentType { get; set; }
    }
}
