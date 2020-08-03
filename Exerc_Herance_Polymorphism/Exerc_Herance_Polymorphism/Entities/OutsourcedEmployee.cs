using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Herance_Polymorphism.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            :base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double pay = base.Payment();
            return pay += AdditionalCharge * 1.1;
        }
    }
}
