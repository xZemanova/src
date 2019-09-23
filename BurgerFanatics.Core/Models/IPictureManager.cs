using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Models
{
    public interface IPictureManager : IDomainService
    {
        IEnumerable<Picture> GetAll();
        Picture GetPictureById(int id);
        Task<Picture> Create(Picture entity);
        void Update(Picture entity);
        void Delete(int id);
    }
}
