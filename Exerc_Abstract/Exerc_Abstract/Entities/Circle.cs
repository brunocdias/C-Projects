using Exerc_Abstract.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Abstract.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
