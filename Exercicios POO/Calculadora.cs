namespace Exercicios_POO
{
    public class Calculadora
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }
        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public static void Dividir(double a, double b)
        {
            double x = a / b;

            Console.WriteLine($"{a} / {b} = {x:f2}");
        }

        public int Potencia(int a, int b)
        {
            return a ^ b;
        }
    }
}