using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class Zip
{
    public string Zipcode { get; set; } = null!;

    public string? City { get; set; }

    public string? State { get; set; }

    public string ZipCrtdId { get; set; } = null!;

    public DateTime ZipCrtdDt { get; set; }

    public string ZipUpdtId { get; set; } = null!;

    public DateTime ZipUpdtDt { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
