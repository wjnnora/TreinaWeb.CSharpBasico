﻿using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Gol", "GM");
            Veiculo moto1 = new Moto();            

            Console.WriteLine(carro1.ToString());
            Console.WriteLine();
            Console.WriteLine(moto1.ToString());
            Console.WriteLine(carro1.Ligar());
            Console.WriteLine(moto1.Equals(moto1));

            
        }
    }
}
