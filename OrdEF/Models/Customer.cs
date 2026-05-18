using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class Customer
{
    public Guid CustomerId { get; set; }

    public string? CustomerFirstName { get; set; }

    public string? CustomerLastName { get; set; }

    public string? CustomerEmail { get; set; }

    public string CustomerCrtdId { get; set; } = null!;

    public DateTime CustomerCrtdDt { get; set; }

    public string CustomerUpdtId { get; set; } = null!;

    public DateTime CustomerUpdtDt { get; set; }

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
