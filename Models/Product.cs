using System;
using System.Collections.Generic;

namespace ECMSD.Models;

public partial class Product
{
    public int Productid { get; set; }

    public string? Productname { get; set; }

    public string? Productcategory { get; set; }
}
