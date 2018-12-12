using CiftciEvi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CiftciEvi.Controllers
{
    public class KullaniciController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Kullanici
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var kullanicilar = db.Kullanicilar.ToList();
            return View(kullanicilar);
        }



        // GET: Kullanici/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kullanici/Ekleme
        public ActionResult Kayit()
        {
            return View();
        }

        // POST: Kullanici/Kayit   Bireysel Üyelik
        [HttpPost]
        public ActionResult Kayit(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                if (db.Kullanicilar.FirstOrDefault(p => p.Cep == kullanici.Cep) !=null)
                {
                    ModelState.AddModelError("Cep", "Bu numara başka bir kullanıcı tarafından kullanılmaktadır.");
                }
                else
                {
                    db.Kullanicilar.Add(kullanici);
                    db.SaveChanges();
                    return RedirectToAction("Login", "Giris");
                }
               
            }
            return View(kullanici);

        }
        // GET: Kullanici/Ekleme
        public ActionResult KurumsalKayit()
        {
            return View();
        }

        // POST: Kullanici/KurumsalKayit   Kurumsal Üyelik
        [HttpPost]
        public ActionResult KurumsalKayit(Kullanici kullanici)
        {
            if (db.Kullanicilar.FirstOrDefault(p => p.Cep == kullanici.Cep) != null)
            {
                ModelState.AddModelError("Cep", "Bu numara başka bir kullanıcı tarafından kullanılmaktadır.");
            }
            else
            {
                db.Kullanicilar.Add(kullanici);
                db.SaveChanges();
                return RedirectToAction("Login", "Giris");
            }
            return View(kullanici);
        }
        // GET: Kullanici/AdminKayit
        public ActionResult AdminKayit()
        {
            return View();
        }

        // POST: Kullanici/AdminKayit   Kurumsal Üyelik
        [HttpPost]
        public ActionResult AdminKayit(Kullanici kullanici)
        {
            if (db.Kullanicilar.FirstOrDefault(p => p.Cep == kullanici.Cep) != null)
            {
                ModelState.AddModelError("Cep", "Bu numara başka bir kullanıcı tarafından kullanılmaktadır.");
            }
            else
            {
                db.Kullanicilar.Add(kullanici);
                db.SaveChanges();
                return RedirectToAction("Login", "Giris");
            }
            return View(kullanici);

        }

        // GET: Kullanici/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kullanici/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Kullanici/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = db.Kullanicilar.FirstOrDefault(i => i.Id == id);
            if (kullanici == null)
            {
                return HttpNotFound();
            }
            return View(kullanici);
        }

        // POST: Kullanici/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Kullanici kullanici = db.Kullanicilar.Find(id);
            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
