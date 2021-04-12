using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KLOVE_Mando.Models
{
    public class BibleContext : DbContext 
    {
        public BibleContext() : base("BibleDb")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BibleContext>());
        }
      
        public DbSet<Verse> Verses { get; set; }
    }
}
