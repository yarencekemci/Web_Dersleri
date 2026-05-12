using Ders2_MVC_Razor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders2_MVC_Razor.Controllers
{
    public class MusterilerController : Controller
    {
        public IActionResult MusteriListesi()
        {
            string[] musteriler = { "Ahmet Yılmaz", "Ayşe Demir", "Mehmet Kaya", "Fatma Çelik", "Ali Vural" };

            ViewBag.Musteriler = musteriler;

            //MusteriListModel musteriListModel=new MusteriListModel
            //{
            //    Id = 1,
            //    Adi = "Ahmet",
            //    Soyadi = "Yılmaz",
            //    Telefon = "555-123-4567",
            //    Adres = "İstanbul, Türkiye",
            //    Il = "İstanbul",
            //    Ilce = "Kadıköy"
            //};

            List<MusteriListModel> list = new List<MusteriListModel>();//liste yapmak için 

            MusteriListModel yeniMusteri = new MusteriListModel();//müşteriyi tek tek eklemek için kullanacağız

            yeniMusteri.Id = 1;
            yeniMusteri.Adi = "Ahmet";
            yeniMusteri.Soyadi = "Yılmaz";
            yeniMusteri.Telefon = "555-123-4567";
            yeniMusteri.Adres = "İstanbul, Türkiye";
            yeniMusteri.Il = "İstanbul";
            yeniMusteri.Ilce = "Kadıköy";

            list.Add(yeniMusteri);
            yeniMusteri = new MusteriListModel();
            yeniMusteri.Id = 2;
            yeniMusteri.Adi = "Zeynep";
            yeniMusteri.Soyadi = "Mazlı";
            yeniMusteri.Telefon = "555-123-4567";
            yeniMusteri.Adres = "gere sokak- ";
            yeniMusteri.Il = "İstanbul";
            yeniMusteri.Ilce = "Kartal";
            list.Add(yeniMusteri);


            return View(list);
        }
    }
}