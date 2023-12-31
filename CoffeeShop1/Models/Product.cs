﻿using System;
using System.Collections.Generic;

namespace CoffeeShop1.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public decimal? Price { get; set; }

    public string? ProductCategory { get; set; }
}
