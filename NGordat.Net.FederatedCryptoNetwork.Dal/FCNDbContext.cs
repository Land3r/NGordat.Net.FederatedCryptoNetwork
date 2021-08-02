using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using NGordat.Net.FederatedCryptoNetwork.Domain.Faucets;

namespace NGordat.Net.FederatedCryptoNetwork.Dal
{
  public class FCNDbContext : DbContext
  {
    public DbSet<Faucet> Faucets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Filename=Database.db", options =>
      {
        options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
      });

      base.OnConfiguring(optionsBuilder);
    }
  }
}
