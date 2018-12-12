using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.Models
{
    public class TarimAraclari
    {
        //Buradaki validasyonlar ara modellerde ayrı ayrı girilecektir.
        public int Id { get; set; }
        
        //Extra 8: Marka icin yeni bir model icab etti
        public MarkaTarimArac Marka { get; set; }

        public string Tipi { get; set; }
        public sbyte ModelYili { get; set; }
        public sbyte TekerlekSayisi { get; set; }
        public sbyte Vites { get; set; }
        public int MotorGucu { get; set; }
        public int CalismaSaati { get; set; }
        public string KabinTipi { get; set; }
        public string CekisTipi { get; set; }
        public Kategori Kategori { get; set; }
    }
}
