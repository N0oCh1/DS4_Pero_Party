using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class CalculadoraEnun1
    {
        public decimal Impuesto (decimal valor)
        {
            return Convert.ToDecimal((valor * 6) / 100);
        }
        public decimal Ganancias (decimal valor)
        {
            return Convert.ToDecimal((valor * 2) / 100);
        }
    }
}
