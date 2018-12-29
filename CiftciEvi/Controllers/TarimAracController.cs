using CiftciEvi.Models;
using CiftciEvi.Models.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CiftciEvi.Controllers
{
    public class TarimAracController : Controller
    {
        private DataContext db = new DataContext();
        private static int kateID = 0;

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult TarimAracEkle()
        {
            var x = db.TarimAracKategoriler.Where(i => i.KID == 0).Count();
            ilanViewModel indexViewModel = new ilanViewModel()
            {

                UstKategoriData = new SelectList(db.TarimAracKategoriler.Where(i => i.KID == 0), "Id", "KategoriAdi"),
                AltKategoriData = new SelectList(db.TarimAracKategoriler.Where(i => i.KID != 0 && i.KID < x), "Id", "KategoriAdi")
            };
            return PartialView("_TarimAracEkle", indexViewModel);
        }

        [HttpPost]
        public PartialViewResult TarimAracEkle(ilanViewModel ilan)
        {
            var x = db.TarimAracKategoriler.Where(i => i.KID == 0).Count();
            ilan.UstKategoriData = new SelectList(db.TarimAracKategoriler.Where(i => i.KID == 0), "Id", "KategoriAdi");
            ilan.AltKategoriData = new SelectList(db.TarimAracKategoriler.Where(i => i.KID != 0 && i.KID < x), "Id", "KategoriAdi");
            return PartialView("_TarimAracEkle", ilan);
        }


        public JsonResult GetCitiesByCountry(int? Id)
        {
            List<TarimAracKategori> result = db.TarimAracKategoriler.Where(x => x.KID == Id).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }



        [HttpGet]
        public PartialViewResult TraktorBicerKayit(int katID = 0)
        {
            List<SelectListItem> kabinTip = (from i in db.KabinTipleri.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KabinTipi,
                                                 Value = i.Id.ToString()
                                             }).ToList();

            List<SelectListItem> cekisTip = (from i in db.CekisTipleri.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.CekisTipi,
                                                 Value = i.Id.ToString()
                                             }).ToList();

            List<SelectListItem> markalar = (from i in db.MarkaTarimAraclari.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.MarkaAdi,
                                                 Value = i.Id.ToString()
                                             }).ToList();

            List<SelectListItem> vites = (from i in db.VitesTarimAraclari.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.VitesTip,
                                                 Value = i.Id.ToString()
                                             }).ToList();
            kateID = katID;
            ViewBag.IlanID = db.Ilanlar;
            ViewBag.Vites = vites;
            ViewBag.Markalar = markalar;
            ViewBag.CekisTipi = cekisTip;
            ViewBag.KabinTipi = kabinTip;

            return PartialView("TraktorBicerKayit");
        }

        [HttpPost]
        public ActionResult TraktorBicerKayit(TarimArac tarimArac)
        {

            tarimArac.TarimAracKategori = db.TarimAracKategoriler.Find(kateID);
            tarimArac.Ilan.EklemeTarihi = DateTime.Now;

            db.TarimAraclar.Add(tarimArac);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public PartialViewResult DigerAraclarKayit()
        {
            return PartialView("_DigerAraclarKayit");
        }




        //public PartialViewResult TraktorBicerEkle()
        //{
        //    return PartialView("_TraktorBicerEkle");
        //    //Traktör
        //    //Biçerdöver
        //}

        ////Toprak & Toprak İşleme, Hasat & Harman, Bitki & Bakım, Ekim & Dikim, Gübreleme, Sulama, Hayvancılık, Taşıma, Ataşman & Yedek Parça
        //public PartialViewResult TarimDigerEkle()
        //{
        //    return PartialView("_TarimDigerEkle");

        //}



    }
}