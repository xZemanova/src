using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Restaurants.Dto
{
    public class GetRestaurant
    {
        public string Id { get; set; }
        public String Name { get; set; }
        public int LocationId { get; set; }
        public String OpeningHours { get; set; }
    }
}
