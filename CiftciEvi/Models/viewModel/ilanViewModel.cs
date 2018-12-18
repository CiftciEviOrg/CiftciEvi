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
        public int AltKAtegoriId { get; set; }//SelectedCountryId

        public SelectList UstKategori { get; set; }
        public SelectList AltKategori { get; set; }
    }
}