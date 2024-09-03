using System;

namespace Laboratorio2
{
    internal class DeterminarNumEnun4
    {
        public bool NumPerfecto(decimal entrada)
        {
            int comparacion = 0;
            for (int i = 1; i < entrada; i++)
            {
                if (entrada % i == 0)
                {
                    comparacion += i;
                }
            }

            return comparacion == entrada;
        }

    }
}
