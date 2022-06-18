using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCEgitimi.NETFramework.Controllers
{
    public class Mvc07PartialController : Controller
    {
        // GET: Mvc07Partial  : Partial ile 1 sayfa içerisindeki bölümleri parçalara ayırıp kullanabiliriz.
        public ActionResult Index()
        {
            return View();
        }
    }
}