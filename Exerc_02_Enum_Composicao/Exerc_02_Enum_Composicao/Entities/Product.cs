using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_02_Enum_Composicao.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
