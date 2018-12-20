using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.Models
{
    public class TarimArac
    {
        //Buradaki validasyonlar ara modellerde ayrı ayrı girilecektir.
        public int Id { get; set; }
        
        //Extra 8: Marka icin yeni bir model icab etti
        public MarkaTarimArac Marka { get; set; }

        public int Tipi { get; set; }
        public int ModelYili { get; set; }
        public int TekerlekSayisi { get; set; }

        //Extra 10:Vites icin yeni bir model icab etti
        public VitesTarimArac Vites { get; set; }
        public int MotorGucuHP { get; set; }
        public int CalismaSaati { get; set; }
        public int KabinTipi { get; set; }
        public int CekisTipi { get; set; }
        public TarimAracKategori Kategori { get; set; }
        public Ilan IlanId { get; set; }
    }
}
