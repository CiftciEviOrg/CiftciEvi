using CiftciEvi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace CiftciEvi.Controllers
{
    public class KullaniciController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Kullanici
        [Route("Profil")]
        public ActionResult Index()
        {
            //bu kısımda kullancının profil bilgilerinin olduğu sayfa olacak.
            var kullanici = db.Kullanicilar.Find(Convert.ToInt32(Session["uyeid"].ToString())); 
            return View(kullanici);
        }
        public ActionResult List()
        {
            var kullanicilar = db.Kullanicilar.ToList();
            return View(kullanicilar);
        }



        // GET: Kullanici/Detay/5
        public ActionResult Detay(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var kullanici = db.Kullanicilar
                                           .Include(i => i.Kurumsal)
                                           .Include(i => i.Kurumsal.Il)
                                           .Include(i => i.Kurumsal.Adres)
                                           .FirstOrDefault(i => i.Id == id);
            if (kullanici == null)
            {
                return HttpNotFound();
            }

            return View(kullanici);
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
                kullanici.KurumsalMi = true;
                db.Kullanicilar.Add(kullanici);
                db.SaveChanges();
                return RedirectToAction("Login", "Giris");
            }
            return View(kullanici);
        }


        // GET: Kullanici/Edit/5
        public ActionResult Guncelle(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = db.Kullanicilar.Find(id);
            if (kullanici.KurumsalMi)
            {
                return RedirectToAction("KurumsalGuncelle", new { id });
            }
            if (kullanici == null)
            {
                return HttpNotFound();
            }
            return View(kullanici);
        }

        // POST: Kullanici/Edit/5
        [HttpPost]
        public ActionResult Guncelle(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                var entity = db.Kullanicilar.Find(kullanici.Id);
                if (entity != null)
                {
                    entity.Adi = kullanici.Adi;
                    entity.Soyadi = kullanici.Soyadi;
                    entity.Cep = kullanici.Cep;
                    entity.Email = kullanici.Email;
                    entity.Sifre = kullanici.Sifre;
                    entity.SifreConfirm = kullanici.SifreConfirm;
                    db.SaveChanges();
                    TempData["Duzenlendi"] = entity;
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }

        // GET: Kullanici/Edit/5
        public ActionResult KurumsalGuncelle(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kullanici kullanici = db.Kullanicilar.Find(id);
            if (kullanici == null)
            {
                return HttpNotFound();
            }
            return View(kullanici);
        }

        // POST: Kullanici/Edit/5
        [HttpPost]
        public ActionResult KurumsalGuncelle(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                var entity = db.Kullanicilar.Find(kullanici.Id);
                if (entity != null)
                {
                    entity.Adi = kullanici.Adi;
                    entity.Soyadi = kullanici.Soyadi;
                    entity.Cep = kullanici.Cep;
                    entity.Email = kullanici.Email;
                    entity.Sifre = kullanici.Sifre;
                    entity.SifreConfirm = kullanici.SifreConfirm;
                    db.SaveChanges();
                    TempData["Duzenlendi"] = entity;
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
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
