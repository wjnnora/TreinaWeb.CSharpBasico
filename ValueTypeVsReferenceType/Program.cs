using System;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passagem por valor
            int numero1 = 3;
            int numero2 = 4;
            numero1 = 5;
            Console.WriteLine("Valor numero1 = {0}\nValor numero2 = {1}", numero1, numero2);
            Console.ReadKey();

            //Passagem por referência
            Teste teste1 = new Teste();
            teste1.quantidade = 3;
            Teste teste2 = new Teste();
            teste2.quantidade = teste1.quantidade;
            teste1.quantidade = 20;
            Console.WriteLine("Teste 1 = {0}\nTeste 2 = {1}", teste1.quantidade, teste2.quantidade);
            Console.ReadKey();
        }
    }

    class Teste
    {
        public int quantidade;       
    }
}
