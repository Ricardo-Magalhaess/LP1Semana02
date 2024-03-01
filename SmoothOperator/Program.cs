using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insere um número inteiro não negativo: ");
            string negro = Console.ReadLine();
            byte n = byte.Parse(negro);
            Console.WriteLine(--n);
            Console.WriteLine(++n);
            Console.WriteLine(n/2);
            Console.WriteLine(n<<3);
            Console.WriteLine(n^5);
            Console.WriteLine(n>10);
        }
    }
}
