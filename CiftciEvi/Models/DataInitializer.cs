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

            #region "TarımAraclari Model"
            List<TarimAraclari> tarimAraclari = new List<TarimAraclari>()
            {
                #region "TRAKTOR"
                //TRAKTÖR
                //Marka başka bir modelde
                //Tipi: sbyte: 4 Farklı tip vardır. Burada sbyte olarak saklanmakta olup
                    //Controller tarafında tipe göre yazdırılacaktır.    
                    //Bahçe Tipi
                    //Tarla Tipi
                    //Bahçe + Tarla
                    
                //Model Yılı: int: Kullanıcıdan alınaccak| Validasyon 4 haneli sayı
                //Vites başka bir modelde
                //MotorGücüHP: int: Kullanıcıdan alınacak| Validasyona tabi olacak sadece sayı
                //CalismaSaati: int: Kullanıcıdan alınacak| Validasyona tabi olacak sadece sayı
                //KabinTipi: sbyte: 4 Farklı kabin tipi vardır. Burada sbyte olarak saklanmakta olup
                    //Controller tarafında tipe göre yazdırılacaktır.
                    //1: Kapalı Kabin
                    //2: Klimalı Kabin
                    //3: Tente
                    //4: Yok
                
                //CekisTipi: sbyte: 2 Farklı cekis tipi vardır. Burada sbyte olarak saklanmakta olup    
                    //Controller tarafında tipe göre yazdırılacaktır.
                    //1: 4x2
                    //2: 4x4
	             
                new TarimAraclari(){
                    Marka =context.markaTarimAraclari.FirstOrDefault(p=>p.Id==1),
                    Tipi=1,
                    ModelYili=1998,
                    Vites=context.vitesTarimAraclari.FirstOrDefault(p=>p.Id==2),
                    MotorGucuHP=110,
                    CalismaSaati=1000,
                    KabinTipi=1,
                    CekisTipi=1
                },

                new TarimAraclari(){
                    Marka =context.markaTarimAraclari.FirstOrDefault(p=>p.Id==10),
                    Tipi=2,
                    ModelYili=1998,
                    Vites=context.vitesTarimAraclari.FirstOrDefault(p=>p.Id==4),
                    MotorGucuHP=80,
                    CalismaSaati=1200,
                    KabinTipi=4,
                    CekisTipi=4
                },
                #endregion
                #region "BicerDover"
                //Marka: Traktördeki gibi başka bir modelden gelir
                //Model Yılı: int: Kullanıcıdan alınaccak| Validasyon 4 haneli sayı
                //Vites başka bir modelde
                //MotorGücüHP: int: Kullanıcıdan alınacak| Validasyona tabi olacak sadece sayı
                //CalismaSaati: int: Kullanıcıdan alınacak| Validasyona tabi olacak sadece sayı
                //KabinTipi: sbyte: 4 Farklı kabin tipi vardır. Burada sbyte olarak saklanmakta olup
                    //Controller tarafında tipe göre yazdırılacaktır.
                    //1: Kapalı Kabin
                    //2: Klimalı Kabin
                    //3: Tente
                    //4: Yok

                new TarimAraclari(){
                    Marka =context.markaTarimAraclari.FirstOrDefault(p=>p.Id==1),
                    ModelYili=1998,
                    Vites=context.vitesTarimAraclari.FirstOrDefault(p=>p.Id==2),
                    MotorGucuHP=110,
                    CalismaSaati=2000,
                    KabinTipi=1,
                },
                #endregion
                #region "Tasima"
                new TarimAraclari(){
                    //Burada marka simdilik boyledir.
                    //ara modeller olustugu zaman Ana modelde marka stringe donecektir
                    Marka=context.markaTarimAraclari.FirstOrDefault(p=>p.Id==4),
                    Tipi =1,
                        //Controller tarafında kontrol edilip
                            //Römork
                            //Konveyör& Bant
                            //Tomruk çekici vinç
                    ModelYili =1999,
                    TekerlekSayisi=6
                },
                #endregion
                #region "Diger"
                new TarimAraclari()
                {
                    //Burada marka simdilik boyledir.
                    //ara modeller olustugu zaman Ana modelde marka stringe donecektir
                    Marka=context.markaTarimAraclari.FirstOrDefault(p=>p.Id==4),
                    ModelYili=2005

                }
                #endregion
            };
            #endregion


            #region "Il"
            string[] illerdizi = {"Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya",
                "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa",
                "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan",
                "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta",
                "İçel(Mersin)", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir",
                "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş", "Mardin", "Muğla", "Muş",
                "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas",
                "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat",
                "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
                "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"};


            for (int i = 0; i < illerdizi.Length; i++)
            {
                String il = illerdizi[i].ToString();
                context.iller.Add(new Il
                {
                    IlAdi = il
                });

            }
            #endregion







            context.SaveChanges();
            base.InitializeDatabase(context);
        }
    }
}