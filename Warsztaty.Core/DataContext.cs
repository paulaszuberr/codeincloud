using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Warsztaty.Core
{
    class DataContext: DbContext
    {
        //nie warto zapamiętywać, dokumentacja bogiem

        public virtual DbSet<ContactModel> Contact { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:warsztatyy1.database.windows.net,1433;Initial Catalog=Warsztatyy1;Persist Security Info=False;User ID=dev14incloud;Password=B00y@h!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
