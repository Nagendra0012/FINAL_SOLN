using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class Payment
{
    public Guid PaymentId { get; set; }

    public Guid? PaymentOrdersId { get; set; }

    public decimal? PaymentAmount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentMethod { get; set; }

    public string PaymentCrtdId { get; set; } = null!;

    public DateTime PaymentCrtdDt { get; set; }

    public string PaymentUpdtId { get; set; } = null!;

    public DateTime PaymentUpdtDt { get; set; }

    public virtual Order? PaymentOrders { get; set; }
}
