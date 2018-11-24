using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public List<Ilan> Ilan { get; set; }

    }
}
