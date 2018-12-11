using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.BusinessLayer.Siniflar
{
    public class GirisBal
    {
        private DataContext db = new DataContext();
        public int? KullaniciVarMi(Kullanici kullanici)
        {
            var kullaniciBilgileri = db.Kullanicilar.FirstOrDefault(p => p.Cep == kullanici.Cep
              && p.Sifre == kullanici.Sifre);
            if (kullaniciBilgileri != null)
            {
                return kullaniciBilgileri.Id;
            }
            else
            {
                return null;
            }
        }
    }
}
