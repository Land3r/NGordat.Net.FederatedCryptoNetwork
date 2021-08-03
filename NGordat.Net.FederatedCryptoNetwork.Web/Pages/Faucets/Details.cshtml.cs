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

        public FaucetViewModel Faucet { get; set; }

        public DetailsModel(FaucetService faucetService)
        {
            _faucetService = faucetService;
        }


        public async Task<IActionResult> OnGetAsync()
        {


            return await Task.FromResult(Page())
        }
    }
}
