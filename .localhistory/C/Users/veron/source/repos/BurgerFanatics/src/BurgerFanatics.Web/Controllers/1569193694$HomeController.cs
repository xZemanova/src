using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using BurgerFanatics.Models;
using BurgerFanatics.Pictures;
using BurgerFanatics.Pictures.Dto;

namespace BurgerFanatics.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BurgerFanaticsControllerBase
    {
        private readonly IPictureAppService _pictureAppService;

        public HomeController(IPictureAppService pictureAppService)
        {
            _pictureAppService = pictureAppService;
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
	}
}