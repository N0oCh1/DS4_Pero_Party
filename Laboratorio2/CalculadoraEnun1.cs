using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class CalculadoraEnun1
    {
        public double Impuesto (double valor)
        {
            return (valor * 6) / 100;
        }
        public double Ganancias (double valor)
        {
            return (valor * 12) / 100;
        }
    }
}
