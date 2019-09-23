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
    public class ReviewManager:DomainService, IReviewManager
    {
        private readonly IRepository<Review> _repositoryReview;
        public ReviewManager(IRepository<Review> repositoryReview)
        {
            _repositoryReview = repositoryReview;
        }

        public async Task<Review> Create(Review entity)
        {
            var review = _repositoryReview.FirstOrDefault(x => x.Id == entity.Id);
            if (review != null)
            {
                throw new UserFriendlyException("Already exists");
            } else
            {
                return await _repositoryReview.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var review = _repositoryReview.FirstOrDefault(x => x.Id == id);
            if (review != null)
            {
                throw new UserFriendlyException("No data found");
            }
            else
            {
                _repositoryReview.Delete(review);
            }
        }

        public IEnumerable<Review> GetAll()
        {
            return _repositoryReview.GetAll();
        }

        public Review GetReviewById(int id)
        {
            return _repositoryReview.Get(id);
        }

        public void Update(Review entity)
        {
            _repositoryReview.Update(entity);
        }
    }
}
