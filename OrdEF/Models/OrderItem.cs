using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class OrderItem
{
    public Guid OrderItemId { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? ProductPriceId { get; set; }

    public decimal? Quantity { get; set; }

    public string OrderItemCrtdId { get; set; } = null!;

    public DateTime OrderItemCrtdDt { get; set; }

    public string OrderItemUpdtId { get; set; } = null!;

    public DateTime OrderItemUpdtDt { get; set; }

    public virtual Order? Order { get; set; }

    public virtual ProductPrice? ProductPrice { get; set; }
}
