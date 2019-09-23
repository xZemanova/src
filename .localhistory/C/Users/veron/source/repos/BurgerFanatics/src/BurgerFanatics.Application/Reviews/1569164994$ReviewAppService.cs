using Abp.Application.Services;
using BurgerFanatics.Models;
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
    }
}
