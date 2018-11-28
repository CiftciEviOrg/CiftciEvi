using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class TarimAraclari
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Tipi { get; set; }
        public int Model { get; set; }
        public sbyte TekerlekSayisi { get; set; }
        public sbyte Vites { get; set; }
        public int MotorGucu { get; set; }
        public int CalismaSaati { get; set; }
        public string KabinTipi { get; set; }
        public string CekisTipi { get; set; }
        public Kategori Kategori { get; set; }
    }
}
