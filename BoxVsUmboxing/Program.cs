using System;

namespace BoxVsUmboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            int inteiro1 = 3;
            object objeto1 = inteiro1;
            Console.WriteLine(objeto1);
            Console.ReadKey();
            //Umboxing
            int inteiro2 = (int)objeto1;
            Console.WriteLine(inteiro2);
            Console.ReadKey();
        }
    }
}
