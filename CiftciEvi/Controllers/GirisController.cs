using CiftciEvi.BusinessLayer;
using System;
using CiftciEvi.BusinessLayer.Models.Giris;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CiftciEvi.BusinessLayer.Siniflar;
namespace CiftciEvi.Controllers
{
    public class GirisController : Controller
    {
        private GirisBAL girisBAL = new GirisBAL();
        // GET: Giris
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session["uyeid"] = null;
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(loginModel kullanici)
        {
            if (ModelState.IsValid)
            {
                int? kullaniciId = girisBAL.KullaniciVarMi(kullanici);
                if(kullaniciId!=null)
                {
                    Session["uyeid"] = kullaniciId;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Tel", "Telefon Numarası veya Şifre Hatalı");
                    return View(kullanici);
                }
                //var login = db.Kullanicilar.FirstOrDefault(p => p.Cep == kullanici.Tel && p.Sifre == kullanici.Sifre);
                //if (login != null)
                //{
                //    Session["uyeid"] = login.Id;
                //    Session["kullaniciadi"] = login.Adi;
                //    Session["yetki"] = login.Adminmi;
                //    return RedirectToAction("Index", "Home");
                //}
                //else
                //{
                //    TempData["hata"] = "Telefon Numarası veya Şifre Yanlış.";
                //    //TempData["LoginHata"] = "Cep Telefonu veya Şifre Yanlış.";
                //    //ModelState.AddModelError(string.Empty, "Cep Telefonu veya Şifre Yanlış.");
                //}
            }
            return View(kullanici);

        }

        [HttpGet]
        public ActionResult Kayit()
        {
            return View();
        }
       



    }
}