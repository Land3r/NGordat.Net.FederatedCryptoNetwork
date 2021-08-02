using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using NGordat.Net.FederatedCryptoNetwork.Domain.Core;

namespace NGordat.Net.FederatedCryptoNetwork.Domain.Faucets
{
  public class Faucet : ActiveEntity
  {
    [Key]
    public int Id { get; set; }

    public int? Ranking { get; set; }

    [DefaultValue(0)]
    public bool? Recommended { get; set; }

    [MaxLength(128)]
    public string Name { get; set; }

    [MaxLength(128)]
    public string PublicUrl { get; set; }

    [MaxLength(128)]
    public string AffiliateUrl { get; set; }

    [MaxLength(256)]
    public string DescriptionShort { get; set; }

    [MaxLength(2048)]
    public string DescriptionLong { get; set; }

    [MaxLength(128)]
    public string Banner { get; set; }

    [MaxLength(128)]
    public string Icon { get; set; }
  }
}
