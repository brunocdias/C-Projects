using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_02_Enum_Composicao.Entities.Enum
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
