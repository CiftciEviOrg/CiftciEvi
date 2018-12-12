using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using CiftciEvi.Models;
using CiftciEvi.Models.viewModel;

namespace CiftciEvi.Controllers
{
    public class GirisController : Controller
    {
        private DataContext db = new DataContext();
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(loginModel kullanici)
        {
            if (ModelState.IsValid)
            {
                var login = db.Kullanicilar.FirstOrDefault(p => p.Cep == kullanici.Cep && p.Sifre == kullanici.Sifre);
                if (login != null) //Session Oluşturulması
                {
                    Session["uyeid"] = login.Id;
                    Session["kullaniciadi"] = login.Adi;
                    Session["yetki"] = login.Adminmi;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["hata"] = "Telefon Numarası veya Şifre Yanlış.";
                }
            }
            return View(kullanici);
        }

        public ActionResult Logout()
        {
            Session["uyeid"] = null;
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Kayit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kayit(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                db.Kullanicilar.Add(kullanici);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(kullanici);
        }



    }
}