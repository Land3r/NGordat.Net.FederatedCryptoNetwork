using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGordat.Net.FederatedCryptoNetwork.Web.ViewModels.Faucets
{
  public class FaucetViewModel
  {
    public int? Ranking { get; set; }

    public bool? Recommended { get; set; }

    public string Name { get; set; }

    public string PublicUrl { get; set; }

    public string AffiliateUrl { get; set; }

    public string DescriptionShort { get; set; }

    public string DescriptionLong { get; set; }

    public string Banner { get; set; }
    public string Icon { get; set; }
    }
}
