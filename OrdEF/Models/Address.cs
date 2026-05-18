using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class Address
{
    public Guid AddressId { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressCity { get; set; }

    public string? AddressState { get; set; }

    public string? AddressZipcode { get; set; }

    public string AddressCrtdId { get; set; } = null!;

    public DateTime AddressCrtdDt { get; set; }

    public string AddressUpdtId { get; set; } = null!;

    public DateTime AddressUpdtDt { get; set; }

    public virtual Zip? AddressZipcodeNavigation { get; set; }

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<Shipment> Shipments { get; set; } = new List<Shipment>();
}
