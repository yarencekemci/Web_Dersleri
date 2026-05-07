using Microsoft.AspNetCore.Mvc;

namespace Ders1_1_MVC.Controllers
{
    public class UrunlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
            // MVC (Model–View–Controller), C# ve ASP.NET gibi web uygulamalarında kullanılan bir tasarım desenidir. Uygulamayı üç parçaya böler: Model (veri ve iş mantığı), View (kullanıcı arayüzü) ve Controller (istekleri yönetip Model ile View arasında köprü kurar). Bu yapı sayesinde kod daha düzenli, anlaşılır ve bakımı kolay olur. Ayrıca ekip çalışmasını da kolaylaştırır çünkü her katman ayrı geliştirilebilir.
        }
    }
}
