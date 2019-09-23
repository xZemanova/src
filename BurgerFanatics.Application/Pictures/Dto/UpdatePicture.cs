using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Pictures.Dto
{
    public class UpdatePicture
    {
        public int Id { get; set; }
        public String FileName { get; set; }
        public String FileContentType { get; set; }
    }
}
