using Microsoft.AspNetCore.Mvc;

namespace AspNetIntro_MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
