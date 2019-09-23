using System.Web.Mvc;

namespace BurgerFanatics.Web.Controllers
{
    public class AboutController : BurgerFanaticsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}