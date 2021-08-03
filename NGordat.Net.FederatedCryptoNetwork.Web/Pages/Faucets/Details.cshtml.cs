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
  public class DetailsModel : PageModel
  {
    private FaucetService _faucetService;

    [TempData]
    public string SuccessMessage { get; set; }

    [TempData]
    public string ErrorMessage { get; set; }

    [BindProperty(SupportsGet = true)]
    public string FaucetName { get; set; }

    [BindProperty(SupportsGet = true)]
    public int FaucetId { get; set; }

    public FaucetViewModel Faucet { get; set; }

    public DetailsModel(FaucetService faucetService)
    {
      _faucetService = faucetService;
    }

    public async Task<IActionResult> OnGetAsync()
    {
      if (FaucetId != 0)
      {
        var faucetEntity = _faucetService.GetById(FaucetId);
        
        if (faucetEntity == null)
        {
          return NotFound("Faucet not found.");
        }

        Faucet = new FaucetViewModel()
        {
          Id = faucetEntity.Id,
          Name = faucetEntity.Name,
          DescriptionShort = faucetEntity.DescriptionShort,
          DescriptionLong = faucetEntity.DescriptionLong,
          Recommended = faucetEntity.Recommended,
          Ranking = faucetEntity.Ranking,
          Icon = faucetEntity.Icon,
          AffiliateUrl = faucetEntity.AffiliateUrl,
          Banner = faucetEntity.Banner,
          PublicUrl = faucetEntity.PublicUrl
        };
      }

      return await Task.FromResult(Page());
    }
  }
}
