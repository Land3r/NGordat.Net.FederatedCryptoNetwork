using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using NGordat.Net.FederatedCryptoNetwork.Dal;
using NGordat.Net.FederatedCryptoNetwork.Domain.Faucets;

namespace NGordat.Net.FederatedCryptoNetwork.Web.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private DatabaseService _databaseService;

        [TempData]
        public string SuccessMessage { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public IndexModel(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            return await Task.FromResult(Page());
        }

        public async Task<IActionResult> OnPostEnsureCreatedAsync()
        {
            _databaseService.CreateSchemaIfNotExists();

            SuccessMessage = "Database updated.";

            return await Task.FromResult(Page());
        }

        public async Task<IActionResult> OnPostInitAsync(string initType)
        {

            if (initType == "Faucets")
            {
                await _databaseService.CreateOrUpdateDataFolderAsync("Faucets", typeof(Faucet));

                SuccessMessage = "Faucets updated.";
            }

            if (string.IsNullOrEmpty(SuccessMessage))
            {
                ErrorMessage = "No init type provided.";
            }

            return await Task.FromResult(Page());
        }
    }
}
