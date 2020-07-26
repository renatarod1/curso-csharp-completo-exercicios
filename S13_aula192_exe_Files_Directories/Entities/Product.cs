﻿using System;
using System.Collections.Generic;
using System.Text;

namespace S13_aula192_exe_Files_Directories.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product() { }

        public Product(string name, double price, int quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalValue() {
            return Price * Quantity;
        }
    }
}
