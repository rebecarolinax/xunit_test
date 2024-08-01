﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_inventory
{
    public class Product
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }

        public Product(string? name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}
