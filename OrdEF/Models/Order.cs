using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class Order
{
    public Guid OrderId { get; set; }

    public Guid? CustomerId { get; set; }

    public Guid? OrderStatusId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string OrdersCrtdId { get; set; } = null!;

    public DateTime OrdersCrtdDt { get; set; }

    public string OrdersUpdtId { get; set; } = null!;

    public DateTime OrdersUpdtDt { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual OrderStatus? OrderStatus { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}
