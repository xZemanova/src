using Abp.Application.Services;
using BurgerFanatics.Reviews.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerFanatics.Reviews
{
    public interface IReviewAppService:IApplicationService
    {
        IEnumerable<GetReview> ListAll();
        Task Create(CreateReview input);
        void Update(UpdateReview input);
        void Delete(DeleteReview input);
        GetReview GetReviewById(GetReviewId input);
    }
}
 