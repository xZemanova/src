using Abp.Application.Services;
using AutoMapper;
using BurgerFanatics.Models;
using BurgerFanatics.Reviews.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Reviews
{
    public class ReviewAppService:ApplicationService, IReviewAppService
    {
        private readonly IReviewManager _reviewManager;
        public ReviewAppService(IReviewManager reviewManager)
        {
            _reviewManager = reviewManager;
        }

        public async Task Create(CreateReview input)
        {
            Review output = Mapper.Map<CreateReview, Review>(input);
            await _reviewManager.Create(output);
        }

        public void Delete(DeleteReview input)
        {
            throw new NotImplementedException();
        }

        public GetReview GetReviewById(GetReviewId input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetReview> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateReview input)
        {
            throw new NotImplementedException();
        }
    }
}
