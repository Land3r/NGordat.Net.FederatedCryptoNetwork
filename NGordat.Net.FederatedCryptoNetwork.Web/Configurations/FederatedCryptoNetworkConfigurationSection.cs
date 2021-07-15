using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGordat.Net.FederatedCryptoNetwork.Web.Configurations
{
  public class FederatedCryptoNetworkConfigurationSection
  {
    public static string SectionName = "FederatedCryptoNetwork";

    public IList<FederatedService> Services { get; set; }
  }
}
