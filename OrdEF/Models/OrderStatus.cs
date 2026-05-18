using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class OrderStatus
{
    public Guid OrderStatusId { get; set; }

    public string? StatusName { get; set; }

    public string OrderStatusCrtdId { get; set; } = null!;

    public DateTime OrderStatusCrtdDt { get; set; }

    public string OrderStatusUpdtId { get; set; } = null!;

    public DateTime OrderStatusUpdtDt { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
