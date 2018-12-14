using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.Models
{
    public class Hayvan
    {

        //Büyükbaş- küçük baş vs ve bunun altındaki şeyler sonsuz kategoriden gelecektir.
        public int Id { get; set; }
        public string Tip { get; set; }//Besilik- buzağı - Damızlık vs..
        public string Cins { get; set; }//Holştayn- Yerli Kara vs..

        [Range(1, 40,ErrorMessage ="Yaş aralığı 1-40 olmalı")]
        public sbyte Yas { get; set; }
        public bool Cinsiyet { get; set; }
        public bool TopluSatis { get; set; }
        public Kategori Kategori { get; set; }
    }
}
