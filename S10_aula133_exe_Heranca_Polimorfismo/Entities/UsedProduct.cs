using System;
using System.Globalization;

namespace S10_aula133_exe_Heranca_Polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) +
                " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
