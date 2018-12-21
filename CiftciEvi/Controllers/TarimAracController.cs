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
        // GET: TarimArac
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








        public PartialViewResult TraktorBicerEkle()
        {
            return PartialView("_TraktorBicerEkle");
            //Traktör
            //Biçerdöver
        }

        //Toprak & Toprak İşleme, Hasat & Harman, Bitki & Bakım, Ekim & Dikim, Gübreleme, Sulama, Hayvancılık, Taşıma, Ataşman & Yedek Parça
        public PartialViewResult TarimDigerEkle()
        {
            return PartialView("_TarimDigerEkle");

        }



    }
}