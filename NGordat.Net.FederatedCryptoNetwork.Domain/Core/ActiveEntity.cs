using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NGordat.Net.FederatedCryptoNetwork.Domain.Interfaces;

namespace NGordat.Net.FederatedCryptoNetwork.Domain.Core
{
  public class ActiveEntity : IActiveEntity
  {
    public bool Active { get; set; }
  }
}
