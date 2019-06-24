using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;
            resultado = SomarValores(10, 10);
            Console.WriteLine(resultado);
            resultado = SomarVariosValores(10, 10, 10, 10, 10, 10);
            Console.WriteLine(resultado);

            int SomarValores(int num1, int num2)
            {
                return num1 + num2;
            }

            int SomarVariosValores(params int[] numeros)
            {
                int result = 0;
                foreach(int numero in numeros)
                {
                    result += numero;
                }
                return result;
            }
        }

        
    }
}
