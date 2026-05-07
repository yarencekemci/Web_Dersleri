using Ders1_1_MVC.Models;
using Microsoft.AspNetCore.Mvc;


namespace Ders1_1_MVC.Controllers
{
    public class UrunlerController : Controller
    {
        [HttpGet] // sayfa ilk yüklendiğinde açılır
        public IActionResult Index() //bu methodun görüntüsünü görmek için projeyi çalıştırdıktan sonra http://localhost:../urunler/Index yazmanız gerekir
        {
            return View();
            // MVC (Model–View–Controller), C# ve ASP.NET gibi web uygulamalarında kullanılan bir tasarım desenidir. Uygulamayı üç parçaya böler: Model (veri ve iş mantığı), View (kullanıcı arayüzü) ve Controller (istekleri yönetip Model ile View arasında köprü kurar). Bu yapı sayesinde kod daha düzenli, anlaşılır ve bakımı kolay olur. Ayrıca ekip çalışmasını da kolaylaştırır çünkü her katman ayrı geliştirilebilir.
        }
        [HttpPost] //açılan index(view) html sayfasında bir form oluşturup bu form altında yer alan inputları doldurup gönderdiğimizde çalışacak olan method. Tetiklenmesi için formun methodun "post" olması gerekir. Form action'ının da bu methodun url'sine yönlendirilmesi gerekir. Yani form action'ı action="/urunler/Index" şeklinde olmalıdır. Asıl tetiklenmeyi form altında yer alan submit butonuna basarak yapacağız. Bu yazılanlar Urunler/Index view sayfasında mevcuttur. Oraya bakarak daha iyi anlayabiliriz.
        public IActionResult Index(string isim, string soyisim)
        {
            return View();
        }
        // eğer bir method başında HttpGet, HttpPost, HttpPull, Httppust, Httpdelete gibi yapılar yazılmadıysa varsayılan olarak HttpGet kabul edilir
        public IActionResult UrunList()
        {
            UrunModel urunModel = new UrunModel();
            return View(urunModel);
        }
        [HttpPost]
        public IActionResult UrunlerList(UrunModel urunModel) //ctrl+.
        {
            if (urunModel.Adi == null)
            {
                //Sayfalar arasında data alşverişi için 3 yapı kullanılır 1)View.Bag.degiskenAdi 2)ViewData["degiskenAdi"] 3)TempData["degiskenAdi"]
                ViewBag.Hata = "Ürün adı boş geçilemez.";
                ViewData["hata"] = "Ürün adı boş geçilemez";
                TempData["hata"] = "Ürün adı boş geçilemez";
                //ViewBag HTML sayfasında göstermek için Razor teknolojisi olan @ işaretine ihtiyaç olacaktır.
                return View(urunModel);
            }
            TempData["eklendi"] = "Ürün kayıt edildi";
            return View();
        }
    }
}
