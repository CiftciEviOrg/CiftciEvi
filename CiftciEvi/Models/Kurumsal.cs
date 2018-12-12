using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.Models
{
    public class Kurumsal
    {
        public int Id { get; set; }
        public bool IsletmeTuru { get; set; }
        public string SabitTel { get; set; }

        public Il Il { get; set; }
        public Adres Adres { get; set; }

        public string FaaliyetAlani { get; set; }
        public string FirmaAdi { get; set; }
        public string TicariUnvan { get; set; }
    }
}
