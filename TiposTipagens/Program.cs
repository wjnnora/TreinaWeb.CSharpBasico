using System;

namespace TiposTipagens
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            var numero2 = 20;
            Console.WriteLine("Número 1 = {0}\nNúmero 2 = {1}", numero1, numero2);
            Console.WriteLine("Total = {0}", numero1 + numero2);
            Console.ReadKey();
            dynamic meuNome = "Wellington Nora";
            Console.WriteLine(meuNome);
            meuNome = 45;
            Console.WriteLine(meuNome);
            Console.ReadKey();
        }
    }
}
