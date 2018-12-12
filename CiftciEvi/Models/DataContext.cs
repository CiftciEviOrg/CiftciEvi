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
        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<MarkaTarimArac> markaTarimAraclari { get; set; }

        public DbSet<VitesTarimArac> vitesTarimAraclari { get; set; }
        

    }
}
