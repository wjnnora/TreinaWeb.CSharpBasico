using System;

namespace AtributosEPropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Wellington";
            cliente1.Idade = 24;

            Cliente cliente2 = new Cliente("Giovane", 17);

            Console.WriteLine("Dados do cliente 1");
            Console.WriteLine();
            Console.WriteLine("Nome: {0}", cliente1.Nome);
            Console.WriteLine("Idade: {0}", cliente1.Idade);
            Cliente.VerificaIdade(cliente1.Idade);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Dados do cliente 2");
            Console.WriteLine();
            Console.WriteLine("Nome: {0}", cliente2.Nome);
            Console.WriteLine("Idade: {0}", cliente2.Idade);
            Cliente.VerificaIdade(cliente2.Idade);



        }
    }
}
