using System;
using System.Text;

namespace EstudandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Wellington";
            string s2 = "Junior";
            string s3 = "Nora";
            Console.WriteLine("{0}", s1 + " " + s2 + " " + s3 + " " + " e" + "estou concatenando" + " " + "Strings");
            Console.ReadKey();
            StringBuilder sb = new StringBuilder();
            sb.Append(s1);
            sb.Append(" ");
            sb.Append(s2);
            sb.Append(" ");
            sb.Append(s3);
            sb.Append(" ");
            Console.WriteLine(sb.ToString());
        }
    }
}
