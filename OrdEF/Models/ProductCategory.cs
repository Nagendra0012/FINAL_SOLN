using System;
using System.Collections.Generic;

namespace Ord.EF.Models;

public partial class ProductCategory
{
    public Guid ProductCategoryId { get; set; }

    public string? ProductCategoryName { get; set; }

    public string ProductCategoryCrtdId { get; set; } = null!;

    public DateTime ProductCategoryCrtdDt { get; set; }

    public string ProductCategoryUpdtId { get; set; } = null!;

    public DateTime ProductCategoryUpdtDt { get; set; }
}
