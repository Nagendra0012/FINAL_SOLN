using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class VwProductMaxPriceIncrease
{
    public Guid? ProductId { get; set; }

    public string? ProductName { get; set; }

    public Guid ProductPriceId { get; set; }

    public decimal? PctIncrease { get; set; }
}
