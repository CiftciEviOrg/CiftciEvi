using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class Gundem
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Yazi { get; set; }
        public Resim Resim { get; set; }
        public int DegerlendirmePuan { get; set; } // tinyint olacak...

        public Kategori Kategori { get; set; }

        public Kullanici Kullanici { get; set; }
    }
}
