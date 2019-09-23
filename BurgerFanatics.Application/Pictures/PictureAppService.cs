using Abp.Application.Services;
using AutoMapper;
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

        public async Task Create(CreatePicture input)
        {
            Picture output = Mapper.Map<CreatePicture, Picture>(input);
            await _pictureManager.Create(output);
        }

        public void Delete(DeletePicture input)
        {
            _pictureManager.Delete(input.Id);
        }

        public GetPicture GetPictureById(GetPictureId input)
        {
            var getPicture = _pictureManager.GetPictureById(input.Id);
            GetPicture output = Mapper.Map<Picture, GetPicture>(getPicture);
            return output;
        }

        public IEnumerable<GetPicture> ListAll()
        {
            var getAll = _pictureManager.GetAll().ToList();
            List<GetPicture> output = Mapper.Map<List<Picture>, List<GetPicture>>(getAll);
            return output;
        }

        public void Update(UpdatePicture input)
        {
            Picture output = Mapper.Map<UpdatePicture, Picture>(input);
            _pictureManager.Update(output);
        }
    }
}
