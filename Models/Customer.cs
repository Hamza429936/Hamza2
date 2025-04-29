using System;
using System.Collections.Generic;

namespace ECMSD.Models;

public partial class Customer
{
    public int Customerid { get; set; }

    public string? Customername { get; set; }

    public string? Customeraddress { get; set; }
}
