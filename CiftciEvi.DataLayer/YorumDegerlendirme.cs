using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class YorumDegerlendirme
    {
        public int Id { get; set; }
        public int Puan { get; set; }
        public string YorumIcerik { get; set; }
        public int Tur { get; set; }
        public HizmetVer HizmetVer { get; set; }
        public Kullanici Kullanici { get; set; }
        public Gundem Gundem { get; set; }
    }
}
