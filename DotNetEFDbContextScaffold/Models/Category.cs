using System;
using System.Collections.Generic;

namespace DotNetEFDbContextScaffold.Models;

public class Category
{
    public long CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public ICollection<Product> Products { get; set; } = new List<Product>();
}
