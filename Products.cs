﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tryingmvc.Models
{
    public class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}