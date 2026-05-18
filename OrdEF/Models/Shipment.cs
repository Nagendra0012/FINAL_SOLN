using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class Shipment
{
    public Guid ShipmentId { get; set; }

    public Guid? ShipmentOrdersId { get; set; }

    public Guid? ShipmentAddressId { get; set; }

    public DateTime? ShipmentDate { get; set; }

    public string ShipmentCrtdId { get; set; } = null!;

    public DateTime ShipmentCrtdDt { get; set; }

    public string ShipmentUpdtId { get; set; } = null!;

    public DateTime ShipmentUpdtDt { get; set; }

    public virtual Address? ShipmentAddress { get; set; }

    public virtual Order? ShipmentOrders { get; set; }
}
