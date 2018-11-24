using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class HizmetVer
    {
        public int Id { get; set; }
        public string Tur { get; set; }
        public int Deneyim { get; set; }
        public int DegerlendirmePuan { get; set; }
        public Kategori Kategori { get; set; }
    }
}
