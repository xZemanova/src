using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Reviews.Dto
{
    public class GetReview
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public int Taste { get; set; }
        public int Texture { get; set; }
        public int Presentation { get; set; }
    }
}
