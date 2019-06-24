using System;
using System.Collections.Generic;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] nomes = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um nome: ");
                nomes[i] = Convert.ToString(Console.ReadLine());                   
            }

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }*/
            /*Dictionary<int, string> meuDicionario = new Dictionary<int, string>();
            meuDicionario.Add(1, "Wellington");
            meuDicionario.Add(2, "Giovane");
            meuDicionario.Add(3, "Jeferson");

            foreach (int chave in meuDicionario.Keys)
            {
                Console.WriteLine("Chave: {0} - Valor: {1}", chave, meuDicionario[chave]);
            }*/

            Console.WriteLine(dia.Segunda);
            
        }
        public enum dia
        {
            Segunda = 0,
            Terça = 1,
            Quarta = 2,
            Quinta = 3,
            Sexta = 4,
            Sábado = 5,
            Doming = 6

        }
    }
    
}
