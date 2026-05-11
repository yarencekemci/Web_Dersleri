using Microsoft.AspNetCore.Mvc;

namespace Ders2_MVC_Razor.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }
    }
}
