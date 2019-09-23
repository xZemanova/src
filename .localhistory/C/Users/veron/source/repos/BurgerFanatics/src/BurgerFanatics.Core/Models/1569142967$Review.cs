using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Models
{
    public class Review: FullAuditedEntity
    {
        public int UserId { get; set; }

        public int RestaurantId { get; set; }

        [Range(0,5, ErrorMessage = "Value must be between 0 to 5")]
        public int Taste { get; set; }

        [Range(0, 5, ErrorMessage = "Value must be between 0 to 5")]
        public int Texture { get; set; }

        [Range(0, 5, ErrorMessage = "Value must be between 0 to 5")]
        public int Presentation { get; set; }
    }
}
