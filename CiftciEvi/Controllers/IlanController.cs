using CiftciEvi.Models;
using CiftciEvi.Models.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CiftciEvi.Controllers
{
    public class IlanController : Controller
    {

        private DataContext db = new DataContext();



        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Ekle()
        {
            return View();
        }



        public PartialViewResult DenemePartial()
        {
            return PartialView("_DenemePartial");
        }


        #region "eski"
        //public ActionResult Ekle(Kategori kategori)
        //{

        //    ViewBag.CategoryID = new SelectList(db.Kategoriler.Where(i => i.KID == 0), "Id", "KategoriAdi");

        //    var x = db.Kategoriler.Where(i => i.KID == 0).Count();


        //    ViewBag.AltCategoryID = new SelectList(db.Kategoriler.Where(i => i.KID != 0 && i.KID < x), "Id","KategoriAdi");
        //    return View();
        //}




        //public ActionResult Ekle()
        //{
        //    var x = db.Kategoriler.Where(i => i.KID == 0).Count();
        //    ilanViewModel indexViewModel = new ilanViewModel()
        //    {

        //        UstKategoriData = new SelectList(db.Kategoriler.Where(i => i.KID == 0), "Id", "KategoriAdi"),
        //        AltKategoriData = new SelectList(db.Kategoriler.Where(i => i.KID != 0 && i.KID < x), "Id", "KategoriAdi")

        //        //CitiesData = new SelectList(City.GetFakeCities(), "CityId", "CityName"),
        //        //CountriesData = new SelectList(Country.GetFakeCountries(), "CountryId", "CountryName"),
        //        //SelectedCityId = -1,
        //        ////SelectedCityId = 15,
        //        //SelectedCountryId = -1
        //    };

        //    return View(indexViewModel);
        //}

        //[HttpPost]
        //public ActionResult Ekle(ilanViewModel ilan)
        //{
        //    var x = db.Kategoriler.Where(i => i.KID == 0).Count();
        //    ilan.UstKategoriData = new SelectList(db.Kategoriler.Where(i => i.KID == 0), "Id", "KategoriAdi");
        //    ilan.AltKategoriData = new SelectList(db.Kategoriler.Where(i => i.KID != 0 && i.KID < x), "Id", "KategoriAdi");
        //    //indexViewModel.CitiesData = new SelectList(City.GetFakeCities(), "CityId", "CityName");
        //    //indexViewModel.CountriesData = new SelectList(Country.GetFakeCountries(), "CountryId", "CountryName");
        //    return View(ilan);
        //}

        //public JsonResult GetCitiesByCountry(int? Id)
        //{
        //    List<Kategori> result = db.Kategoriler.Where(x => x.KID == Id).ToList();
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}
        #endregion
    }
}