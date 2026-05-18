using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class CustomerAddress
{
    public Guid CustomerAddressId { get; set; }

    public Guid? CustomerAddressCustomerId { get; set; }

    public Guid? CustomerAddressAddressId { get; set; }

    public string CustomerAddressCrtdId { get; set; } = null!;

    public DateTime CustomerAddressCrtdDt { get; set; }

    public string CustomerAddressUpdtId { get; set; } = null!;

    public DateTime CustomerAddressUpdtDt { get; set; }

    public string? CustomerAddressActvInd { get; set; }

    public string? CustomerAddressDflt { get; set; }

    public virtual Address? CustomerAddressAddress { get; set; }

    public virtual Customer? CustomerAddressCustomer { get; set; }
}
