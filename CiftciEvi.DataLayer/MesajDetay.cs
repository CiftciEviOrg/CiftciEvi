using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    class MesajDetay
    {
        public int Id { get; set; }
        public string Icerik { get; set; }
        public Mesaj MesajId { get; set; }
    }
}
