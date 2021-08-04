using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGordat.Net.FederatedCryptoNetwork.Web.ViewModels.Faucets
{
    public static class FaucetCategory
    {
        private static string[] _list = { "Crypto.xyz", "Faucet", "Airdrop", "Exchange", "Game", "MicroWallet", "Mining", "Other" };

        public static string[] GetAll()
        {
            return _list;
        }

        public static IEnumerable<SelectListItem> GetListItems()
        {
            return _list.Select(item => new SelectListItem()
            {
                Text = item,
                Value = item
            });
        }
    }
}
