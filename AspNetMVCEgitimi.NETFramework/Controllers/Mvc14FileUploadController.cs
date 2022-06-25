using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;  //bu kütüphane dosya işlemleri için gereklidir. 

namespace AspNetMVCEgitimi.NETFramework.Controllers
{
    public class Mvc14FileUploadController : Controller
    {
        // GET: Mvc14FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase dosya)  //Ön yüzdeki file upload elementine name olarak ne isim verdiysek onu kullanmalıyız.
        {
            if (dosya != null && dosya.ContentLength > 0)
            {
                // Dosya işlemleri için system.ıo kütüphanesini using ile yurıya eklemeliyiz! 
                var uzanti = Path.GetExtension(dosya.FileName);  // Dosya uzantı kontrölü yapmak istersek 
                if (uzanti == ".jpg" || uzanti == ".jpeg" || uzanti == ".png" || uzanti == ".gif") // Sadece bu uzantılardaki dosyaları kabul et. 
                {
                    // 1. Yöntem Random(Rastgele) İsimle Dosya Yükleme
                    var klasor = Server.MapPath("/Images");  //Resmi yükleyeceğimiz klasör (Eğer projede bu klasör yoksa oluşturmalıyız yoksa hata verir!)
                    var randomFileName = Path.GetRandomFileName();  //Rastgele dosya ismi oluşturma metodu. 
                    var fileName = Path.ChangeExtension(randomFileName, ".jpg");  //dosya adı ve uzantısını değiştirip birleştirdik. 
                    var path = Path.Combine(klasor, fileName); // klasör ve resim adını birleştirdik. 
                    dosya.SaveAs(path); // resmi farklı kaydet metoduyla sunucuya yüklüyoruz. 
                    //ViewBag.ResimAdi = fileName;
                    //ViewBag.ResimPath = path;

                    // 2. Yöntem - Resmi Kendi Adıyla Yükleme
                    var dosyaAdi = Path.GetFileName(dosya.FileName);
                    var yol = Path.Combine(klasor, dosyaAdi);

                    dosya.SaveAs(yol);

                    ViewBag.ResimAdi = dosyaAdi;
                }
                else ViewData["message"] = "Sadece .jpg, .jpeg, .png ve .gif uzantılı dosyaları yükleyebilirsiniz! ";
            }
            return View();
        }
    }
}