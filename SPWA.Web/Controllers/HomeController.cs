using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SPWA.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SPWAControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}