using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using SPWA.People;

namespace SPWA.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SPWAControllerBase
    {
        private readonly IPersonService _personService;

        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }

        public ActionResult Index()
        {
            //获取列表
            //var p = _personService.GetPersons();
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}