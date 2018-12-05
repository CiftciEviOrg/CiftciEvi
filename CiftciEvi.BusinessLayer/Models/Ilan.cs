using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class Ilan
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
        public string Kimden { get; set; }
        public Resim Resim { get; set; }
        public DateTime Tarih { get; set; }
        public Durum Durum { get; set; }
        public Adres Adres { get; set; }
        public Onay Onay { get; set; }

        public List<Kategori> Kategori { get; set; }
    }
}
