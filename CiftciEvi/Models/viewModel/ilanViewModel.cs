using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CiftciEvi.Models.viewModel
{
    public class ilanViewModel
    {
        public int UstKategoriId { get; set; }//SelectedCityId        
        public int AltKategoriId { get; set; }//SelectedCountryId

        public SelectList UstKategoriData { get; set; } //CountryData
        public SelectList AltKategoriData { get; set; } //CityData
    }
}