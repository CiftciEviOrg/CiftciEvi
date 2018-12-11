using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.Models
{
    public class YorumDegerlendirme
    {
        public int Id { get; set; }
        public sbyte Puan { get; set; } //sbyte
        public string YorumIcerik { get; set; }
        public bool Tur { get; set; } //true ise yorum false degerlendirme
        public HizmetVer HizmetVer { get; set; }
        public Kullanici Kullanici { get; set; }
        public Gundem Gundem { get; set; }
    }
}
