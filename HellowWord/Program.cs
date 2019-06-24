using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.Write("Meu nome é Wellington.");
            Console.Write(" e tenho 24 anos de idade.");
            Console.ReadKey();*/
            string s1 = "Wellington";
            string s2 = s1.Substring(0, 4);
            Console.WriteLine("String 1 = {0}\nString 2 = {1}", s1, s2);            
            string s3 = @"Meu\nNome\nÉ\nWellington\nNora";
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
