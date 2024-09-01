using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class CalculadoraEnun1
    {
        public double Impuesto (decimal valor)
        {
            return Convert.ToDouble((valor * 6) / 100);
        }
        public double Ganancias (decimal valor)
        {
            return Convert.ToDouble((valor * 20) / 100);
        }
    }
}
