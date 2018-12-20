using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftciEvi.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("CiftciEviDb")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<MarkaTarimArac> MarkaTarimAraclari { get; set; }

        public DbSet<VitesTarimArac> VitesTarimAraclari { get; set; }

        public DbSet<Il> Iller { get; set; }

        public DbSet<Agac> Agaclar { get; set; }

        public DbSet<TarimArac> TarimAraclar { get; set; }

        public DbSet<Hayvan> Hayvanlar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<TarimAracKategori> TarimAracKategoriler { get; set; }
        public DbSet<HayvanKategori> HayvanKategoriler { get; set; }
        public DbSet<HizmetveIsKategori> HizmetveIsKategoriler { get; set; }


    }
}
