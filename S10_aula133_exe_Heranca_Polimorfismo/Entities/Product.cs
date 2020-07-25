using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace S10_aula133_exe_Heranca_Polimorfismo.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() {
            return "Notebook $" + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
