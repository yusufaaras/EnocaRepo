using EncodeEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaDataAccessLayer.Concrete
{
    public class Context : DbContext
    {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=EnocaChallengeDb;Username=postgres;Password=yusuf123");
            }

            public DbSet<Carrier> Carrier { get; set; }
            public DbSet<Orders> Orders { get; set; }
            public DbSet<CarrierConfigurations> CarrierConfigurations { get; set; }
        
    }
}
