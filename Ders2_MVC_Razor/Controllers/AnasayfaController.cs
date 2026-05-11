using Microsoft.AspNetCore.Mvc;

namespace Ders2_MVC_Razor.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Index()
        {
            // Razor, ASP.NET Core içinde kullanılan bir web teknolojisidir.
            // HTML ile C# kodlarını aynı dosyada yazmayı sağlar.
            // Dinamik web sayfaları oluşturmak için kullanılır.
            // Razor dosyalarının uzantısı genellikle .cshtml olur.
            // Sayfa içinde C# kodu yazmak için @ işareti kullanılır.
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }
    }
}
