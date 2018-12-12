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

        public sbyte Tipi { get; set; }
        public int ModelYili { get; set; }
        public sbyte TekerlekSayisi { get; set; }

        //Extra 10:Vites icin yeni bir model icab etti
        public VitesTarimArac Vites { get; set; }
        public int MotorGucuHP { get; set; }
        public int CalismaSaati { get; set; }
        public sbyte KabinTipi { get; set; }
        public sbyte CekisTipi { get; set; }
        public Kategori Kategori { get; set; }
    }
}
