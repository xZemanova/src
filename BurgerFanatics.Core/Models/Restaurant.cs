using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Models
{
    public class Restaurant : FullAuditedEntity
    {
        [Required]
        [Display(Name = "Name")]
        public String Name { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }

        [Display(Name = "Opening Hours")]
        public String OpeningHours { get; set; }
        
        public virtual Location Location { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

    }
}
