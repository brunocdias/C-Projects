using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exerc_02_Herence_Polymorphism.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Customs fee: $ ");
            sb.Append(CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(")");
            return sb.ToString();
        }
    }
}
