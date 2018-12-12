using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CiftciEvi.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        public override void InitializeDatabase(DataContext context)
        {



            #region "Tarim Aaçlari için markalar|MarkaTarimAraclari Model"
            //Tarim Aaçlari için marka dizisi
            string[] markalarDizi = {"Agrifarm","Agripower", "Antonio Carraro","Artrak Superline", "Aslan Traktör",
                "Başak", "Başkent", "BCS", "BMC","Bolinder-Munktell", "Bozok","Branson","Carraro","Case IH","Chery",
                "Claas","DavidBrown","Deutz","Dexta","Ebro","Eicher","Erkunt","Farmtrac","Fendt","Ferrari","Fiat",
                "Ford","Foton","Goldoni","Hanomag","Harman","Hars","Hattat","Hema","Huerlimann","IMT","International",
                "İrtem","İşbora","JCB","John Deere","Kaan","Karataş","Katsu","Kioti","Kubota","Lamborghini","Landini",
                "Leyland","LG","Lombardin","LS Tractor","Mahindra","Massey Ferguson","Massey Harris","McCormick",
                "Mehmet Şimşeker","Mercedes","New Holland","Perkis","Same","Solis","Steyr","Super Major","Super Star",
                "Tafe","Taral","Tümosan","Türk Traktör", "Universal","Ursus","Uzel Traktör","Valpadana","Valtra","Yağmur","Zetor"
            };

            for (int i = 0; i < markalarDizi.Length; i++)
            {
                String il = markalarDizi[i].ToString();
                context.markaTarimAraclari.Add(new MarkaTarimArac
                {
                    MarkaAdi = il
                });

            }
            #endregion

            #region "Tarim Aaçlari için vites tip|VitesTarimAraclari Model"
            //Tarim Aaçlari için vitestip dizisi
            string[] viteslerDizi = {"6 İleri - 2 Geri","8 İleri - 2 Geri","8 İleri - 8 Geri","9 İleri - 3 Geri","9 İleri - 9 Geri","12 İleri - 4 Geri","12 İleri - 12 Geri","15 İleri - 15 Geri","16 İleri - 8 Geri","16 İleri - 16 Geri","18 İleri - 18 Geri","24 İleri - 24 Geri","32 İleri - 32 Geri","36 İleri - 36 Geri"
            };

            for (int i = 0; i < viteslerDizi.Length; i++)
            {
                String il = viteslerDizi[i].ToString();
                context.vitesTarimAraclari.Add(new VitesTarimArac
                {
                    VitesTip = il
                });

            }
            #endregion















            context.SaveChanges();
            base.InitializeDatabase(context);
        }
    }
}