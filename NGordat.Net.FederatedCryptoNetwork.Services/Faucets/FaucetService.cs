using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NGordat.Net.FederatedCryptoNetwork.Dal;
using NGordat.Net.FederatedCryptoNetwork.Domain.Core;
using NGordat.Net.FederatedCryptoNetwork.Domain.Faucets;

namespace NGordat.Net.FederatedCryptoNetwork.Services.Faucets
{
  public class FaucetService
  {
    private FCNDbContext _dbContext;

    public FaucetService(FCNDbContext context)
    {
      _dbContext = context;
    }

    public IEnumerable<Faucet> GetAll()
    {
      return _dbContext.Faucets.Where(item => item.Active == true).OrderBy(elm => elm.Ranking != null).ThenBy(elm => elm.Ranking);
    }
  }
}
