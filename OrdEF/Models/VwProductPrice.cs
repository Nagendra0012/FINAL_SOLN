using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class VwProductPrice
{
    public Guid ProductId { get; set; }

    public string? ProductName { get; set; }

    public Guid ProductPriceId { get; set; }

    public decimal? ProductPricePrice { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
