using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using BurgerFanatics.Models;
using BurgerFanatics.Pictures;
using BurgerFanatics.Pictures.Dto;
using BurgerFanatics.Reviews;
using BurgerFanatics.Reviews.Dto;

namespace BurgerFanatics.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BurgerFanaticsControllerBase
    {
        private readonly IPictureAppService _pictureAppService;
        private readonly IReviewAppService _reviewAppService;

        public HomeController(IPictureAppService pictureAppService, IReviewAppService reviewAppService)
        {
            _pictureAppService = pictureAppService;
            _reviewAppService = reviewAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddPicture(string fileName, string fileContentType)
        {
            CreatePicture _picture = new CreatePicture { FileName = fileName, FileContentType = fileContentType };
            await _pictureAppService.Create(_picture);
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddReview()
        {
            CreateReview _review = new CreateReview { RestaurantId = 0, Presentation = 5, Taste = 2, Texture = 3 };
            await _reviewAppService.Create(_review);
            return View();
        }
    }
}