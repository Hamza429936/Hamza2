using System;
using System.Collections.Generic;

namespace ECMSD.Models;

public partial class Order
{
    public int Orderid { get; set; }

    public int? Customerid { get; set; }

    public DateOnly? Shippingdate { get; set; }

    public string? Orderstatus { get; set; }

    public decimal? Totalamount { get; set; }
}
