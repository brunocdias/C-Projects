using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exerc_02_Herence_Polymorphism.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (used) $ ");
            sb.Append(PriceTag());
            sb.Append(" Manufacture date: ");
            sb.Append(ManufactureDate.ToString("dd/MM/yyyy"));
            sb.Append(")");
            return sb.ToString();
        }

        

    }
}
