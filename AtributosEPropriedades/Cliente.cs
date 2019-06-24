using System;
using System.Collections.Generic;
using System.Text;

namespace AtributosEPropriedades
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Cliente()
        {
            this.Idade = 0;
            this.Nome = "";
        }

        public Cliente(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public static void VerificaIdade(int idade)
        {
            if (idade >= 0 && idade < 18)
            {
                Console.WriteLine("É menor de idade.");
            }
            else
                Console.WriteLine("É maior de idade.");
        }
    }
}
