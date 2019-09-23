using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using BurgerFanatics.Models;
using BurgerFanatics.Pictures;

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
        public ActionResult AddPicture(Picture pic)
        {

        }
	}
}