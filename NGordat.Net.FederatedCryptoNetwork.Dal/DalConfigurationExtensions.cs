using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

namespace NGordat.Net.FederatedCryptoNetwork.Dal
{
  public class DalConfigurationExtensions
  {
    public static void Configure(IServiceCollection services)
    {
      services.AddScoped<FCNDbContext>();
      services.AddScoped<DatabaseService>();
    }
  }
}
