using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace HighClick.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : HighClickControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}