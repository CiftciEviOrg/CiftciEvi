using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.Models
{
    public class Onay
    {
        public int Id { get; set; }
        public bool OnayRed { get; set; }
        public string Aciklama { get; set; }
        public Kullanici Kullanici { get; set; }

    }
}
