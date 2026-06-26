using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCEgitimi.Controllers
{
    public class MVC02HtmlHelpersControlIer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
