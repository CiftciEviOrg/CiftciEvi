using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class IsIlani
    {
        public int Id { get; set; }

        [Required]
        public string CalismaSekli { get; set; } // tam, yarı, günübirlik zaman

        [Required]
        public sbyte Deneyim { get; set; }    // 1-10 a kadar. sbyte
        public Kategori Kategori { get; set; }
    }
}
