using AspNetMVCEgitimi.NETFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCEgitimi.NETFramework.Controllers
{
    public class Mvc11ModelValidationController : Controller
    {
        // GET: Mvc11ModelValidation  : Validation ile model class larımızda doğrulama işlemi yaparız. 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid)    //ModelState IsValid parametreden gelen uye nesnesinin validation kurallarını denetler
                                       //ve kurallara uyulmuşsa kod bloğundaki kodları çalıştırır
            {
                ViewBag.UyeBilgi = $"Üye Adı : {uye.Ad} <hr /> Üye Soyad : {uye.Soyad} <hr /> " +
                $"Üye Mail : {uye.Email} <hr /> Üye TC : {uye.TcKimlikNo}";
            }

            return View();
        }
        public ActionResult UyeDuzenle(int? id)  //üye düzenlemenin get metodunda id parametresi beklenir çünkü bu id ye göre
                                                 // ilgili üye bilgileri ekrana getirilir. (int? Soru işareti boş geçilebilir
                                                 //anlamına geliyor. Bu da önemli.
        {
            Uye uye = new Uye()
            {
                Id = 1,
                Ad = "Fatih",
                Soyad = "Sultan",
                Email = "fatih@sultan.net",
                TcKimlikNo = "52651307380"
            };
            return View(uye);
        }
        [HttpPost]
        public ActionResult UyeDUzenle(Uye uye)
        {
            if (ModelState.IsValid)    //ModelState IsValid parametreden gelen uye nesnesinin validation kurallarını denetler
                                       //ve kurallara uyulmuşsa kod bloğundaki kodları çalıştırır
            {
                ViewBag.UyeBilgi = $"Üye Adı : {uye.Ad} <hr /> Üye Soyad : {uye.Soyad} <hr /> " +
                $"Üye Mail : {uye.Email} <hr /> Üye TC : {uye.TcKimlikNo}";
            }

            return View(uye);  //uye nesnesini veiw a geri yolla. 
        }
        public ActionResult UyeListesi()
        {
            var uyeListesi = new List<Uye> {
            new Uye()
            {
                Id = 1,
                Ad = "Fatih",
                Soyad = "Sultan",
                Email = "fatih@sultan.net",
                TcKimlikNo = "52651307380"
            },
            new Uye()
            {
                Id = 2,
                Ad = "Mehmet",
                Soyad = "Aslan",
                Email = "fatihsdas@sultan.net",
                TcKimlikNo = "12351307380"
            },
            new Uye()
            {
                Id = 3,
                Ad = "Ömer",
                Soyad = "Aslan",
                Email = "omer@sultan.net",
                TcKimlikNo = "31251307380"
            }
            };
            return View(uyeListesi);  //view a uyelistesi nesnesini gönderdik. 
        }
        public ActionResult UyeSil(int? id)  //üye düzenlemenin get metodunda id parametresi beklenir çünkü bu id ye göre
                                                 // ilgili üye bilgileri ekrana getirilir. (int? Soru işareti boş geçilebilir
                                                 //anlamına geliyor. Bu da önemli.
        {
            Uye uye = new Uye()
            {
                Id = 1,
                Ad = "Fatih",
                Soyad = "Sultan",
                Email = "fatih@sultan.net",
                TcKimlikNo = "52651307380"
            };
            return View(uye);
        }
        [HttpPost]
        public ActionResult Uyesil()
        {
            //burada kayıt veritabanından silinir ve sayfa liste ekranına yönlendirilir. 
            TempData["Mesaj"] = "<div class = 'alert alert-danger'>Kayıt Silindi!</div>";
            return View();
        }

    }
}