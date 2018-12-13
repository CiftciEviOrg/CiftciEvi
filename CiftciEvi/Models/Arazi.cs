using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.Models
{
    public class Arazi
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Metrakare alanı zorunludur")]
        [Range(0, int.MaxValue, ErrorMessage = "Geçersiz değer")]
        public int Mkare { get; set; }

        [Range(0,10,ErrorMessage ="Geçersiz Değer")]
        public sbyte Su { get; set; }

        public bool AgacVarMi { get; set; }

        public Agac Agac { get; set; }

        public string AgacCins { get; set; }

        public int Adet { get; set; }

        public Kategori Kategori { get; set; }
    }
}
