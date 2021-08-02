using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using NGordat.Net.FederatedCryptoNetwork.Services.Faucets;

namespace NGordat.Net.FederatedCryptoNetwork.Services
{
  public class ServicesConfigurationExtensions
  {
    public static void Configure(IServiceCollection services)
    {
      services.AddScoped<FaucetService>();
    }
  }
}
