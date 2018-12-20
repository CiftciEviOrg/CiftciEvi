using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.Models
{
    public class HizmetVer
    {
        public int Id { get; set; }

        [Required]
        public string Tur { get; set; }
        [Required]
        public int Deneyim { get; set; }
        public int DegerlendirmePuan { get; set; } //sbyte
        public Kategori Kategori { get; set; }
        public Ilan IlanId { get; set; }
    }
}
