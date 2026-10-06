using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AndreLashley.Web.Controllers
{
    public class PrivacyController : Controller
    {
        public ActionResult BcClockCheck()
        {
            return View();
        }
    }
}
