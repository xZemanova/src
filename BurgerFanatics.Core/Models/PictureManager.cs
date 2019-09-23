using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Models
{
    public class PictureManager : DomainService, IPictureManager
    {
        private readonly IRepository<Picture> _repositoryPicture;
        public PictureManager(IRepository<Picture> repositoryPicture)
        {
            _repositoryPicture = repositoryPicture;
        }

        public async Task<Picture> Create(Picture entity)
        {
            var picture = _repositoryPicture.FirstOrDefault(x => x.Id == entity.Id);
            if (picture != null)
            {
                throw new UserFriendlyException("Already exists");
            }
            else
            {
                return await _repositoryPicture.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var picture = _repositoryPicture.FirstOrDefault(x => x.Id == id);
            if (picture != null)
            {
                throw new UserFriendlyException("No data found");
            }
            else
            {
                _repositoryPicture.Delete(picture);
            }
        }

        public IEnumerable<Picture> GetAll()
        {
            return _repositoryPicture.GetAll();
        }

        public Picture GetPictureById(int id)
        {
            return _repositoryPicture.Get(id);
        }

        public void Update(Picture entity)
        {
            _repositoryPicture.Update(entity);
        }
    }
}
