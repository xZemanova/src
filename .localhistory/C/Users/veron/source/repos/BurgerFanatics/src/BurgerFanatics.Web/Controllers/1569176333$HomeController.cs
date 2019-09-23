using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace BurgerFanatics.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BurgerFanaticsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}