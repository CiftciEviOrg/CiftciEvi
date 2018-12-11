using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class Arazi
    {
        public int Id { get; set; }
        public int Mkare { get; set; }
        public int Su { get; set; }
        public Agac Agac { get; set; }
        public Kategori Kategori { get; set; }
    }
}
