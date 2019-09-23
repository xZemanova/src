using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Models
{
    public interface IReviewManager:IDomainService
    {
        IEnumerable<Review> GetAll();
        Review GetReviewById(int id);
        Task<Review> Create(Review entity);
        void Update(Review entity);
        void Delete(int id);
    }
}
