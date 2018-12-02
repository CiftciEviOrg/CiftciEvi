using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class Gundem
    {
        public int Id { get; set; }

        [Required]
        public string Baslik { get; set; }

        [Required]
        public string Yazi { get; set; }

        public Resim Resim { get; set; }
        public sbyte DegerlendirmePuan { get; set; } //sbyte

        public Kategori Kategori { get; set; }

        public Kullanici Kullanici { get; set; }
    }
}
