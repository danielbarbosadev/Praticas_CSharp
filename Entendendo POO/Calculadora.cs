using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entendendo_POO
{
    public class Calculadora
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public static int Dividir(int a, int b)
        {
            return a / b;
        }

        public static int Potencia(int a, int b)
        {
            return a ^ b;
        }
    }
}