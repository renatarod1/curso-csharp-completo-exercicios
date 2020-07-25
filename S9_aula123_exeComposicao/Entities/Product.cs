﻿using System;
using System.Collections.Generic;
using System.Text;

namespace S9_aula123_exeComposicao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() {
        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
    }
}
