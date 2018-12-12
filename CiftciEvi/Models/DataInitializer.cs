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
                context.markaTarimAracs.Add(new MarkaTarimArac
                {
                    MarkaAdi = il
                });

            }
            context.SaveChanges();





            context.SaveChanges();

            base.InitializeDatabase(context);
        }
    }
}