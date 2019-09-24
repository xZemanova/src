using Abp.Application.Services;
using BurgerFanatics.Pictures.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Pictures
{
    public interface IPictureAppService : IApplicationService
    {
        IEnumerable<GetPicture> ListAll();
        Task Create(PictureCreate input);
        void Update(UpdatePicture input);
        void Delete(DeletePicture input);
        GetPicture GetPictureById(GetPictureId input);
    }
}
