using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique uma altura para um cilindro: ");
            string alt = Console.ReadLine();
            Console.Write("Indique um raio para um cilindro: ");
            string ra = Console.ReadLine();
            float a = float.Parse(alt);
            float r = float.Parse(ra);
            float v = MathF.PI * MathF.Pow(r,2) * a;
            float s = 2 * MathF.PI * r * (r+a);
            Console.WriteLine($"Volume do cilindro {v}");
            Console.WriteLine($"area da superficie do cilindro {s}");      
        }
    }
}
