using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CiftciEvi.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        public override string ToString()
        {

            return base.ToString();
        }
    }
}