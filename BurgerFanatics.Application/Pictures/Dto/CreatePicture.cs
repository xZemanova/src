using Abp.AutoMapper;
using BurgerFanatics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Pictures.Dto
{
    [AutoMapFrom(typeof(Picture))]
    public class PictureCreate
    {
        public String FileName { get; set; }
        public String FileContentType { get; set; }
    }
}
