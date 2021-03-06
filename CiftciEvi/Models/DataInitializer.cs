﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CiftciEvi.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
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
                string marka = markalarDizi[i].ToString();
                context.MarkaTarimAraclari.Add(new MarkaTarimArac
                {
                    MarkaAdi = marka
                });

            }
            #endregion

            #region "Tarim Aaçlari için vites tip|VitesTarimAraclari Model"
            //Tarim Aaçlari için vitestip dizisi
            string[] viteslerDizi = {"6 İleri - 2 Geri","8 İleri - 2 Geri","8 İleri - 8 Geri","9 İleri - 3 Geri","9 İleri - 9 Geri","12 İleri - 4 Geri","12 İleri - 12 Geri","15 İleri - 15 Geri","16 İleri - 8 Geri","16 İleri - 16 Geri","18 İleri - 18 Geri","24 İleri - 24 Geri","32 İleri - 32 Geri","36 İleri - 36 Geri"
            };

            for (int i = 0; i < viteslerDizi.Length; i++)
            {
                string vites = viteslerDizi[i].ToString();
                context.VitesTarimAraclari.Add(new VitesTarimArac
                {
                    VitesTip = vites
                });

            }
            #endregion

            //Comment
            #region "TarımAraclari Model"
            //List<TarimArac> tarimAraclari = new List<TarimArac>()
            //{
            //    #region "TRAKTOR"
            //    //TRAKTÖR
            //    //Marka başka bir modelde
            //    //Tipi: sbyte: 4 Farklı tip vardır. Burada sbyte olarak saklanmakta olup
            //        //Controller tarafında tipe göre yazdırılacaktır.    
            //        //Bahçe Tipi
            //        //Tarla Tipi
            //        //Bahçe + Tarla

            //    //Model Yılı: int: Kullanıcıdan alınaccak| Validasyon 4 haneli sayı
            //    //Vites başka bir modelde
            //    //MotorGücüHP: int: Kullanıcıdan alınacak| Validasyona tabi olacak sadece sayı
            //    //CalismaSaati: int: Kullanıcıdan alınacak| Validasyona tabi olacak sadece sayı
            //    //KabinTipi: sbyte: 4 Farklı kabin tipi vardır. Burada sbyte olarak saklanmakta olup
            //        //Controller tarafında tipe göre yazdırılacaktır.
            //        //1: Kapalı Kabin
            //        //2: Klimalı Kabin
            //        //3: Tente
            //        //4: Yok

            //    //CekisTipi: sbyte: 2 Farklı cekis tipi vardır. Burada sbyte olarak saklanmakta olup    
            //        //Controller tarafında tipe göre yazdırılacaktır.
            //        //1: 4x2
            //        //2: 4x4

            //    new TarimArac(){
            //        Marka =context.MarkaTarimAraclari.FirstOrDefault(p=>p.Id==1),
            //        Tipi=1,
            //        ModelYili=1998,
            //        Vites=context.VitesTarimAraclari.FirstOrDefault(p=>p.Id==2),
            //        MotorGucuHP=110,
            //        CalismaSaati=1000
            //        //KabinTipi=1,
            //        //CekisTipi=1
            //    },

            //    new TarimArac(){
            //        Marka =context.MarkaTarimAraclari.FirstOrDefault(p=>p.Id==10),
            //        Tipi=2,
            //        ModelYili=1998,
            //        Vites=context.VitesTarimAraclari.FirstOrDefault(p=>p.Id==4),
            //        MotorGucuHP=80,
            //        CalismaSaati=1200 
            //        //KabinTipi=4,
            //        //CekisTipi=4,

            //    },
            //    #endregion
            //    #region "BicerDover"
            //    //Marka: Traktördeki gibi başka bir modelden gelir
            //    //Model Yılı: int: Kullanıcıdan alınaccak| Validasyon 4 haneli sayı
            //    //Vites başka bir modelde
            //    //MotorGücüHP: int: Kullanıcıdan alınacak| Validasyona tabi olacak sadece sayı
            //    //CalismaSaati: int: Kullanıcıdan alınacak| Validasyona tabi olacak sadece sayı
            //    //KabinTipi: sbyte: 4 Farklı kabin tipi vardır. Burada sbyte olarak saklanmakta olup
            //        //Controller tarafında tipe göre yazdırılacaktır.
            //        //1: Kapalı Kabin
            //        //2: Klimalı Kabin
            //        //3: Tente
            //        //4: Yok

            //    new TarimArac(){
            //        Marka =context.MarkaTarimAraclari.FirstOrDefault(p=>p.Id==1),
            //        ModelYili=1998,
            //        Vites=context.VitesTarimAraclari.FirstOrDefault(p=>p.Id==2),
            //        MotorGucuHP=110,
            //        CalismaSaati=2000
            //        //KabinTipi=1,
            //    },
            //    #endregion
            //    #region "Tasima"
            //    new TarimArac(){
            //        //Burada marka simdilik boyledir.
            //        //ara modeller olustugu zaman Ana modelde marka stringe donecektir
            //        Marka=context.MarkaTarimAraclari.FirstOrDefault(p=>p.Id==4),
            //        Tipi =1,
            //            //Controller tarafında kontrol edilip
            //                //Römork
            //                //Konveyör& Bant
            //                //Tomruk çekici vinç
            //        ModelYili =1999

            //    },
            //    #endregion
            //    #region "Diger"
            //    new TarimArac()
            //    {
            //        //Burada marka simdilik boyledir.
            //        //ara modeller olustugu zaman Ana modelde marka stringe donecektir
            //        Marka=context.MarkaTarimAraclari.FirstOrDefault(p=>p.Id==4),
            //        ModelYili=2005

            //    }
            //    #endregion
            //};
            //foreach (var item in tarimAraclari)
            //{
            //    context.TarimAraclar.Add(item);
            //}
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
                string il = illerdizi[i].ToString();
                context.Iller.Add(new Il
                {
                    IlAdi = il
                });

            }
            #endregion

            //Comment
            #region "Hayvanlar Modeli"
            //List<Hayvan> hayvanlar = new List<Hayvan>() {
            //    //büyükbaş-küçük baş ve alt kategorileri sonsuz kategori modelinden gelecektir..
            //    //controller tarafında kategoriden gelen bilgiye göre listeler kontrol edilecek 

            //    //Kategoriden- Büyükbaş-Dana Geldiği varsılayarak
            //    new Hayvan(){Tip="Besilik",Cins="Holştayn",Yas=3,Cinsiyet=true,TopluSatis=false},

            //    //Kategoriden- Küçükbaş-Koç Geldiği varsılayarak
            //    new Hayvan(){Tip="Besilik",Cins="Holştayn",Yas=3,Cinsiyet=true,TopluSatis=false}
            //};
            //foreach (var item in hayvanlar)
            //{
            //    context.Hayvanlar.Add(item);
            //}
            #endregion

            //Eski kategoriler Comment
            #region "Sonsuz Kategori"
            List<Kategori> kategoriler = new List<Kategori>() {
                new Kategori(){KategoriAdi="Tarım Araçları	",KID=0},
                new Kategori(){KategoriAdi="Arazi",KID=  0},
                new Kategori(){KategoriAdi="HizmetVer",KID=  0   },
                new Kategori(){KategoriAdi="İş İlanı",KID=  0   },
                new Kategori(){KategoriAdi="HayvanlarAlemi",KID=  0   },
                new Kategori(){KategoriAdi="Traktör",KID=  1   },
                new Kategori(){KategoriAdi="Toprak & Toprak İşleme",KID=  1   },
                new Kategori(){KategoriAdi="Hasat & Harman",KID=  1   },
                new Kategori(){KategoriAdi="Bitki & Bakım",KID=  1   },
                new Kategori(){KategoriAdi="Ekim & Dikim",KID=  1   },
                new Kategori(){KategoriAdi="Gübreleme",KID=  1   },
                new Kategori(){KategoriAdi="Sulama",KID=  1   },
                new Kategori(){KategoriAdi="Hayvancılık",KID=  1   },
                new Kategori(){KategoriAdi="Taşıma",KID=  1   },
                new Kategori(){KategoriAdi="Ataşman & Yedek Parça	",KID=  1   },
                new Kategori(){KategoriAdi="Arazi",KID=  2   },
                new Kategori(){KategoriAdi="Tarla",KID=  2   },
                new Kategori(){KategoriAdi="Bağ/ Bahçe",KID=  2   },
                new Kategori(){KategoriAdi="Diğer",KID=  2   },
                new Kategori(){KategoriAdi="Tarim Hizmeti",KID=  3   },
                new Kategori(){KategoriAdi="Hayvancılık İşi Hizmeti",KID=  3   },
                new Kategori(){KategoriAdi="Kümes Hayvanları İşi Hizmeti",KID=  3   },
                new Kategori(){KategoriAdi="Arıcılık İşi Hizmeti",KID=  3   },
                new Kategori(){KategoriAdi="Bahçıvanlık Hizmeti",KID=  3   },
                new Kategori(){KategoriAdi="Tarim İşi",KID=  4   },
                new Kategori(){KategoriAdi="Hayvancılık İşi",KID=  4   },
                new Kategori(){KategoriAdi="Kümes Hayvancılığı İşi",KID=  4   },
                new Kategori(){KategoriAdi="Arıcılık İşi",KID=  4   },
                new Kategori(){KategoriAdi="Bahçıvan İşi",KID=  4   },
                new Kategori(){KategoriAdi="Büyükbaş",KID=  5   },
                new Kategori(){KategoriAdi="Küçüşbaş",KID=  5   },
                new Kategori(){KategoriAdi="Kümes Hayvanları",KID=  5   },
                new Kategori(){KategoriAdi="Böcekler",KID=  5   },
                new Kategori(){KategoriAdi="Ağaç Sökme Makinesi",KID=  7   },
                new Kategori(){KategoriAdi="Çapa Makinesi",KID=  7   },
                new Kategori(){KategoriAdi="Diskaro",KID=  7   },
                new Kategori(){KategoriAdi="Döküm Merdane",KID=  7   },
                new Kategori(){KategoriAdi="Kültivatör",KID=  7   },
                new Kategori(){KategoriAdi="Lazer Tesviye",KID=  7   },
                new Kategori(){KategoriAdi="Odun Kırma Makinesi",KID=  7   },
                new Kategori(){KategoriAdi="Pulluk",KID=  7   },
                new Kategori(){KategoriAdi="Rotovatör",KID=  7   },
                new Kategori(){KategoriAdi="Sap Parçalama Makinesi",KID=  7   },
                new Kategori(){KategoriAdi="Tırmık",KID=  7   },
                new Kategori(){KategoriAdi="Toprak & Çim Havalandırma",KID=  7   },
                new Kategori(){KategoriAdi="Toprak Burgu Makinesi",KID=  7   },
                new Kategori(){KategoriAdi="Toprak Öğütme Makinesi",KID=  7   },
                new Kategori(){KategoriAdi="Biçerdöver",KID=  8   },
                new Kategori(){KategoriAdi="Ağaç Silkeleme Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Balya & Silaj",KID=  8   },
                new Kategori(){KategoriAdi="Fındık Patoz & Toplama",KID=  8   },
                new Kategori(){KategoriAdi="Fıstık Hasat Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Harman Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Hububat Kurutma Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Meyve & Zeytin Toplama",KID=  8   },
                new Kategori(){KategoriAdi="Mısır Hasat Tablası",KID=  8   },
                new Kategori(){KategoriAdi="Mısır Silaj Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Pamuk Toplama Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Pancar Sökme Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Patates & Soğan Sökme",KID=  8   },
                new Kategori(){KategoriAdi="Pirinç Hasat Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Saman Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Silaj Paketleme Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Tohum Eleme Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Zeytin Eleme Makinesi",KID=  8   },
                new Kategori(){KategoriAdi="Budama Makinesi",KID=  9   },
                new Kategori(){KategoriAdi="Çayır, Çim & Ot Biçme",KID=  9   },
                new Kategori(){KategoriAdi="Orak & Tırpan Makinesi",KID=  9   },
                new Kategori(){KategoriAdi="Pelet Makinesi",KID=  9   },
                new Kategori(){KategoriAdi="Talaş Hazırlama",KID=  9   },
                new Kategori(){KategoriAdi="Üfleme Toplama Makinesi",KID=  9   },
                new Kategori(){KategoriAdi="Yaprak & Dal Öğütme Makinesi",KID=  9   },
                new Kategori(){KategoriAdi="Ekim Makinesi",KID=  10  },
                new Kategori(){KategoriAdi="Patates & Soğan Ekme",KID=  10  },
                new Kategori(){KategoriAdi="Tütün Dikim Makinesi",KID=  10  },
                new Kategori(){KategoriAdi="Gübre Dağıtma & Serpme",KID=  11  },
                new Kategori(){KategoriAdi="Gübre Kurutma Makinesi",KID=  11  },
                new Kategori(){KategoriAdi="Gübre Parçalama",KID=  11  },
                new Kategori(){KategoriAdi="Gübre Sıyırıcı Sistemi",KID=  11  },
                new Kategori(){KategoriAdi="Gübre Tankı",KID=  12  },
                new Kategori(){KategoriAdi="Pancar Motoru",KID=  12  },
                new Kategori(){KategoriAdi="Sulama Makinesi",KID=  12  },
                new Kategori(){KategoriAdi="Su Pompası & Motoru",KID=  12  },
                new Kategori(){KategoriAdi="Hayvan Kaşıma Fırçası",KID=  13  },
                new Kategori(){KategoriAdi="Süt Sağma Makinesi",KID=  13  },
                new Kategori(){KategoriAdi="Yem Ezme & Kırma",KID=  13  },
                new Kategori(){KategoriAdi="Yem Karma Makinesi",KID=  13  },
                new Kategori(){KategoriAdi="Yem Üretim Makinesi",KID=  13  },
                new Kategori(){KategoriAdi="Römork",KID=  14  },
                new Kategori(){KategoriAdi="Konveyör, Bant & Helezon",KID=  14  },
                new Kategori(){KategoriAdi="Tomruk Çekici Vinç",KID=  14  },
                new Kategori(){KategoriAdi="At",KID=  30  },
                new Kategori(){KategoriAdi="Boğa",KID=  30  },
                new Kategori(){KategoriAdi="Deve",KID=  30  },
                new Kategori(){KategoriAdi="Eşek",KID=  30  },
                new Kategori(){KategoriAdi="İnek",KID=  30  },
                new Kategori(){KategoriAdi="Lama",KID=  30  },
                new Kategori(){KategoriAdi="Manda",KID=  30  },
                new Kategori(){KategoriAdi="Keçi",KID=  31  },
                new Kategori(){KategoriAdi="Koç",KID=  31  },
                new Kategori(){KategoriAdi="Koyun",KID=  31  },
                new Kategori(){KategoriAdi="Kuzu",KID=  31  },
                new Kategori(){KategoriAdi="Deve Kuşu",KID=  32  },
                new Kategori(){KategoriAdi="Güvercin",KID=  32  },
                new Kategori(){KategoriAdi="Hindi",KID=  32  },
                new Kategori(){KategoriAdi="Horoz",KID=  32  },
                new Kategori(){KategoriAdi="Kaz",KID=  32  },
                new Kategori(){KategoriAdi="Kuğu",KID=  32  },
                new Kategori(){KategoriAdi="Ördek",KID=  32  },
                new Kategori(){KategoriAdi="Tavuk",KID=  32  },
                new Kategori(){KategoriAdi="Tavus Kuşu",KID=  32  },
                new Kategori(){KategoriAdi="Kuluçkalık Yumurta",KID=  32  },
                new Kategori(){KategoriAdi="Arı",KID=  33  },
                new Kategori(){KategoriAdi="İpek Böceği",KID=  33  }
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            #endregion


            //Yeni kategoriler
            #region TarimAracKategorileri
            List<TarimAracKategori> tarimAracKategorileri = new List<TarimAracKategori>()
            {
                new TarimAracKategori{KategoriAdi="	Traktör	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Biçerdöver	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Toprak & Toprak İşleme	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Hasat & Harman	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Bitki & Bakım	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Ekim & Dikim	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Gübreleme	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Sulama	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Hayvancılık	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Taşıma	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Ataşman & Yedek Parça	",KID=  0   },
                new TarimAracKategori{KategoriAdi="	Ağaç Sökme Makinesi	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Çapa Makinesi	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Diskaro	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Döküm Merdane	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Kültivatör	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Lazer Tesviye	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Odun Kırma Makinesi	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Pulluk	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Rotovatör	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Sap Parçalama Makinesi	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Tırmık	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Toprak & Çim Havalandırma	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Toprak Burgu Makinesi	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Toprak Öğütme Makinesi	",KID=  3   },
                new TarimAracKategori{KategoriAdi="	Ağaç Silkeleme Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Balya & Silaj	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Fındık Patoz & Toplama	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Fıstık Hasat Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Harman Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Hububat Kurutma Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Meyve & Zeytin Toplama	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Mısır Hasat Tablası	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Mısır Silaj Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Pamuk Toplama Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Pancar Sökme Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Patates & Soğan Sökme	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Pirinç Hasat Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Saman Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Silaj Paketleme Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Tohum Eleme Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Zeytin Eleme Makinesi	",KID=  4   },
                new TarimAracKategori{KategoriAdi="	Budama Makinesi	",KID=  5   },
                new TarimAracKategori{KategoriAdi="	Çayır, Çim & Ot Biçme	",KID=  5   },
                new TarimAracKategori{KategoriAdi="	Orak & Tırpan Makinesi	",KID=  5   },
                new TarimAracKategori{KategoriAdi="	Pelet Makinesi	",KID=  5   },
                new TarimAracKategori{KategoriAdi="	Talaş Hazırlama	",KID=  5   },
                new TarimAracKategori{KategoriAdi="	Üfleme Toplama Makinesi	",KID=  5   },
                new TarimAracKategori{KategoriAdi="	Yaprak & Dal Öğütme Makinesi	",KID=  5   },
                new TarimAracKategori{KategoriAdi="	Ekim Makinesi	",KID=  6   },
                new TarimAracKategori{KategoriAdi="	Patates & Soğan Ekme	",KID=  6   },
                new TarimAracKategori{KategoriAdi="	Tütün Dikim Makinesi	",KID=  6   },
                new TarimAracKategori{KategoriAdi="	Gübre Dağıtma & Serpme	",KID=  7   },
                new TarimAracKategori{KategoriAdi="	Gübre Kurutma Makinesi	",KID=  7   },
                new TarimAracKategori{KategoriAdi="	Gübre Parçalama	",KID=  7   },
                new TarimAracKategori{KategoriAdi="	Gübre Sıyırıcı Sistemi	",KID=  7   },
                new TarimAracKategori{KategoriAdi="	Gübre Tankı	",KID=  8   },
                new TarimAracKategori{KategoriAdi="	Pancar Motoru	",KID=  8   },
                new TarimAracKategori{KategoriAdi="	Sulama Makinesi	",KID=  8   },
                new TarimAracKategori{KategoriAdi="	Su Pompası & Motoru	",KID=  8   },
                new TarimAracKategori{KategoriAdi="	Hayvan Kaşıma Fırçası	",KID=  9   },
                new TarimAracKategori{KategoriAdi="	Süt Sağma Makinesi	",KID=  9   },
                new TarimAracKategori{KategoriAdi="	Yem Ezme & Kırma	",KID=  9   },
                new TarimAracKategori{KategoriAdi="	Yem Karma Makinesi	",KID=  9   },
                new TarimAracKategori{KategoriAdi="	Yem Üretim Makinesi	",KID=  9   },
                new TarimAracKategori{KategoriAdi="	Römork	",KID=  10   },
                new TarimAracKategori{KategoriAdi="	Konveyör, Bant & Helezon	",KID=  10   },
                new TarimAracKategori{KategoriAdi="	Tomruk Çekici Vinç	",KID=  10   }
            };
            foreach (var item in tarimAracKategorileri)
            {
                context.TarimAracKategoriler.Add(item);
            }
            #endregion

            #region HizmetveIsKategorileri
            List<HizmetveIsKategori> hizmetveIsKategorileri = new List<HizmetveIsKategori>()
            {
                new HizmetveIsKategori(){KategoriAdi="	Tarim İşleri	",KID=  0   },
                new HizmetveIsKategori(){KategoriAdi="	Hayvancılık İşleri	",KID=  0   },
                new HizmetveIsKategori(){KategoriAdi="	Kümes Hayvancılığı	",KID=  0   },
                new HizmetveIsKategori(){KategoriAdi="	Arıcılık 	",KID=  0   },
                new HizmetveIsKategori(){KategoriAdi="	Bahçıvanlık Hizmeti	",KID=  0   },
                new HizmetveIsKategori(){KategoriAdi="	Hasat & Harman	",KID=  1   },
                new HizmetveIsKategori(){KategoriAdi="	Bitki & Bakım	",KID=  1   },
                new HizmetveIsKategori(){KategoriAdi="	Ekim & Dikim	",KID=  1   },
                new HizmetveIsKategori(){KategoriAdi="	Gübreleme	",KID=  1   },
                new HizmetveIsKategori(){KategoriAdi="	Sulama	",KID=  1   }

            };
            foreach (var item in hizmetveIsKategorileri)
            {
                context.HizmetveIsKategoriler.Add(item);
            }
            #endregion

            #region HayvanKategorileri
            List<HayvanKategori> hayvanKategorileri = new List<HayvanKategori>()
            {
                new HayvanKategori(){KategoriAdi="	Büyükbaş	",KID=  0   },
                new HayvanKategori(){KategoriAdi="	Küçükbaş	",KID=  0   },
                new HayvanKategori(){KategoriAdi="	Kümes Hayvanları	",KID=  0   },
                new HayvanKategori(){KategoriAdi="	Böcekler	",KID=  0   },
                new HayvanKategori(){KategoriAdi="	At 	",KID=  2   },
                new HayvanKategori(){KategoriAdi="	Boğa	",KID=  2   },
                new HayvanKategori(){KategoriAdi="	Deve	",KID=  2   },
                new HayvanKategori(){KategoriAdi="	Eşek	",KID=  2   },
                new HayvanKategori(){KategoriAdi="	İnek	",KID=  2   },
                new HayvanKategori(){KategoriAdi="	Lama	",KID=  2   },
                new HayvanKategori(){KategoriAdi="	Manda	",KID=  2   },
                new HayvanKategori(){KategoriAdi="	Keçi	",KID=  3   },
                new HayvanKategori(){KategoriAdi="	Koç 	",KID=  3   },
                new HayvanKategori(){KategoriAdi="	Koyun	",KID=  3   },
                new HayvanKategori(){KategoriAdi="	Kuzu	",KID=  3   },
                new HayvanKategori(){KategoriAdi="	Deve Kuşu	",KID=  4   },
                new HayvanKategori(){KategoriAdi="	Güvercin	",KID=  4   },
                new HayvanKategori(){KategoriAdi="	Hindi	",KID=  4   },
                new HayvanKategori(){KategoriAdi="	Horoz	",KID=  4   },
                new HayvanKategori(){KategoriAdi="	Kaz	",KID=  4   },
                new HayvanKategori(){KategoriAdi="	Kuğu	",KID=  4   },
                new HayvanKategori(){KategoriAdi="	Ördek	",KID=  4   },
                new HayvanKategori(){KategoriAdi="	Tavuk	",KID=  4   },
                new HayvanKategori(){KategoriAdi="	Tavus Kuşu	",KID=  4   },
                new HayvanKategori(){KategoriAdi="	Kuluçkalık Yumurta	",KID=  5   },
                new HayvanKategori(){KategoriAdi="	Arı	",KID=  5   },
                new HayvanKategori(){KategoriAdi="	İpek Böceği	",KID=  5   }

            };
            foreach (var item in hayvanKategorileri)
            {
                context.HayvanKategoriler.Add(item);
            }
            #endregion

            #region TarimAracKabinTipleri
            List<TarimAracKabinTipi> tarimAracKabinTipleri = new List<TarimAracKabinTipi>() {
                new TarimAracKabinTipi{KabinTipi="Kapalı Kabin" },
                new TarimAracKabinTipi{KabinTipi="Klimalı Kabin" },
                new TarimAracKabinTipi{KabinTipi="Tente" },
                new TarimAracKabinTipi{KabinTipi="Yok" }
            };
            foreach (var item in tarimAracKabinTipleri)
            {
                context.KabinTipleri.Add(item);
            }
            #endregion

            #region TarimAracCekisTipleri


            List<TarimAracCekisTipi> tarimAracCekisTipleri = new List<TarimAracCekisTipi>() {
                new TarimAracCekisTipi{CekisTipi="4X2" },
                new TarimAracCekisTipi{CekisTipi="4X4" }
            };
            foreach (var item in tarimAracCekisTipleri)
            {
                context.CekisTipleri.Add(item);
            }
            #endregion

            context.SaveChanges();
            base.Seed(context);
        }
    }
}