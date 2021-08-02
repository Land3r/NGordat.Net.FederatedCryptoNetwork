using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using NGordat.Net.FederatedCryptoNetwork.Services.Faucets;
using NGordat.Net.FederatedCryptoNetwork.Web.ViewModels.Faucets;

namespace NGordat.Net.FederatedCryptoNetwork.Web.Pages.Faucets
{
  public class ListModel : PageModel
  {
    public FaucetService _faucetService { get; set; }

    public IList<FaucetViewModel> Items { get; set; }

    public ListModel(FaucetService faucetService)
    {
      _faucetService = faucetService;
    }
    public void OnGet()
    {
      Items = _faucetService.GetAll().Select(faucet => new FaucetViewModel()
      {
        Name = faucet.Name,
        DescriptionShort = faucet.DescriptionShort,
        DescriptionLong = faucet.DescriptionLong,
        Recommended = faucet.Recommended,
        Ranking = faucet.Ranking,
        Icon = faucet.Icon,
        AffiliateUrl = faucet.AffiliateUrl,
        Banner = faucet.Banner,
        PublicUrl = faucet.PublicUrl
      }).ToList();
    }
  }
}
