using Abp.Application.Services;
using BurgerFanatics.Models;
using BurgerFanatics.Pictures.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Pictures
{
    public class PictureAppService : ApplicationService, IPictureAppService
    {
        private readonly IPictureManager _pictureManager;
        public PictureAppService(IPictureManager pictureManager)
        {
            _pictureManager = pictureManager;
        }

        public Task Create(CreatePicture input)
        {
            throw new NotImplementedException();
        }

        public void Delete(DeletePicture input)
        {
            throw new NotImplementedException();
        }

        public GetPicture GetReviewById(GetPictureId input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetPicture> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(UpdatePicture input)
        {
            throw new NotImplementedException();
        }
    }
}
