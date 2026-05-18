using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class ProductPrice
{
    public Guid ProductPriceId { get; set; }

    public Guid? ProductPriceProductId { get; set; }

    public decimal? ProductPricePrice { get; set; }

    public DateTime? ProductPriceEffDate { get; set; }

    public string ProductPriceCrtdId { get; set; } = null!;

    public DateTime ProductPriceCrtdDt { get; set; }

    public string ProductPriceUpdtId { get; set; } = null!;

    public DateTime ProductPriceUpdtDt { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Product? ProductPriceProduct { get; set; }
}
