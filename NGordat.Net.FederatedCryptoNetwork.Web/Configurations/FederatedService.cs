using System;

namespace NGordat.Net.FederatedCryptoNetwork.Web.Configurations
{
  public class FederatedService
  {
    public string Name { get; set; }

    public bool Enabled { get; set; }

    public FederatedServiceKind Kind { get; set; }
  }

  [Flags]
  public enum FederatedServiceKind
  {
    Faucet,
    Game,
    Market
  }
}