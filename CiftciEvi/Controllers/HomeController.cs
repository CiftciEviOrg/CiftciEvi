using CiftciEvi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CiftciEvi.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home //Anasayfa metodu
        public ActionResult Index()
        {
            var urunler = db.Kullanicilar.ToList();
            return View(urunler);
        }
    }
}