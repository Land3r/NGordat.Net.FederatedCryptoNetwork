using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGordat.Net.FederatedCryptoNetwork.Dal
{
  public class DatabaseService
  {
    private FCNDbContext _context;

    public DatabaseService(FCNDbContext context)
    {
      _context = context;
    }

    public void CreateSchemaIfNotExists()
    {
      bool isUpToDate = _context.Database.EnsureCreated();
    }
  }
}
