using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.DataLayer
{
    public class Kullanici
    {
        public int Id { get; set; }

        //[Column(TypeName = "varchar(30)")]
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string SifreConfirm { get; set; }
        public string Cep { get; set; }
        public bool Adminmi { get; set; }
    }
}
