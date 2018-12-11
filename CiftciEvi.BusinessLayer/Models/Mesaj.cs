using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class Mesaj
    {
        public int Id { get; set; }
        public Kullanici GonderenId { get; set; }
        public Kullanici AliciId { get; set; }
        public Ilan Ilan { get; set; }
    }
}
