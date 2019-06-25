using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Gol", "GM");
            Veiculo moto1 = new Moto();

            //Adicionando antigos donos
            Dono dono1 = new Dono();
            dono1.Nome = "Wellington";
            dono1.Idade = 24;

            Dono dono2 = new Dono();
            dono2.Nome = "Giovane";
            dono2.Idade = 22;

            carro1.AdicionaAntigosDonos(dono1);
            carro1.AdicionaAntigosDonos(dono2);

            Console.WriteLine(carro1.ToString());
            Console.WriteLine();
            Console.WriteLine(carro1.Ligar());
            Console.WriteLine(carro1.Desligar());
            Console.WriteLine(carro1.Abastecer());
            Console.WriteLine(carro1.Desabastecer());
            

            Console.WriteLine(moto1.ToString());
            Console.WriteLine();
            Console.WriteLine(moto1.Ligar());
            Console.WriteLine(moto1.Desligar());
            Console.WriteLine(moto1.Abastecer());
            Console.WriteLine(moto1.Desabastecer());

            //Imprimindo antios donos
            foreach (Dono dono in carro1.ListaAntigosDonos())
            {
                Console.WriteLine("Um dos antigos donos é {0} com idade de {1}", dono.Nome, dono.Idade);
            }

            Console.ReadKey();
            
        }
    }
}
