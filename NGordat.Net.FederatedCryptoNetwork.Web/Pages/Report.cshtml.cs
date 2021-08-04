using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NGordat.Net.FederatedCryptoNetwork.Web.ViewModels.Reports;

namespace NGordat.Net.FederatedCryptoNetwork.Web.Pages
{
    public class ReportModel : PageModel
    {
        [BindProperty]
        public ReportViewModel Report { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        [TempData]
        public string SuccessMessage { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            this.Report = new ReportViewModel()
            {
                Category = Category ?? null,
                Name = Name ?? null,
                Id = 0,
                Title = null,
                Description = null
            };

            return await Task.FromResult(Page());
        }

        public async Task<IActionResult> OnPostCreateReportAsync()
        {
            return Page();
        }
    }
}
