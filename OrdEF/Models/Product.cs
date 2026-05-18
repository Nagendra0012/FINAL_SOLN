using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class Product
{
    public Guid ProductId { get; set; }

    public string? ProductName { get; set; }

    public string ProductCrtdId { get; set; } = null!;

    public DateTime ProductCrtdDt { get; set; }

    public string ProductUpdtId { get; set; } = null!;

    public DateTime ProductUpdtDt { get; set; }

    public virtual ICollection<ProductPrice> ProductPrices { get; set; } = new List<ProductPrice>();
}
