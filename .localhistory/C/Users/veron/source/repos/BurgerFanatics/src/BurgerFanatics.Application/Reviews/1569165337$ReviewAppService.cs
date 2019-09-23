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
            _reviewManager.Delete(input.Id);
        }

        public GetReview GetReviewById(GetReviewId input)
        {
            var getReview = _reviewManager.GetReviewById(input.Id);
            GetReview output = Mapper.Map<Review, GetReview>(getReview);
            return output;
        }

        public IEnumerable<GetReview> ListAll()
        {
            var getAll = _reviewManager.GetAll().ToList();
            List<GetReview> output = Mapper.Map<List<Review>, List<GetReview>>(getAll);
            return output;

        }

        public void Update(UpdateReview input)
        {
            Review output = Mapper.Map<UpdateReview, Review>(input);
        }
    }
}
