using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            ///minimo e maximo de todos os tipos
            sbyte sbminimo = sbyte.MinValue;
            sbyte sbmaximo = sbyte.MaxValue;

            short shminimo = short.MinValue;
            short shmaximo = short.MaxValue;

            int inminimo = int.MinValue;
            int inmaximo = int.MaxValue;

            long lominimo = long.MinValue;
            long lomaximo = long.MaxValue;

            byte byminimo = byte.MinValue;
            byte bymaximo = byte.MaxValue;

            ushort usminimo = ushort.MinValue;
            ushort usmaximo = ushort.MaxValue;

            uint uiminimo = uint.MinValue;
            uint uimaximo = uint.MaxValue;

            ulong ulminimo = ulong.MinValue;
            ulong ulmaximo = ulong.MaxValue;

            char chminimo = char.MinValue;
            char chmaximo = char.MaxValue;
            
            ///valoress especiais a partir de float e double
            float flminimo = float.NegativeInfinity;
            float flmaximo = float.PositiveInfinity;

            double doublenan = double.NaN;

            Console.WriteLine($"sbyte max e min values: {sbminimo}  {sbmaximo}");
            Console.WriteLine($"short max e min values: {shminimo}  {shmaximo}");
            Console.WriteLine($"int max e min values: {inminimo}  {inmaximo}");
            Console.WriteLine($"long max e min values: {lominimo}  {lomaximo}");
            Console.WriteLine($"byte max e min values: {byminimo}  {bymaximo}");
            Console.WriteLine($"ushort max e min values: {usminimo}  {usmaximo}");
            Console.WriteLine($"uint max e min values: {uiminimo}  {uimaximo}");
            Console.WriteLine($"ulong max e min values: {ulminimo}  {ulmaximo}");
            Console.WriteLine($"char max e min values: {chminimo}  {chmaximo}");
            Console.WriteLine($"float max e min values: {flminimo}  {flmaximo}");
            Console.WriteLine($"double max e min values: {doublenan}");
            Console.WriteLine();
            uiminimo -= 5;
            uimaximo += 5;
            Console.WriteLine($"uints com overflow: {uiminimo}  {uimaximo}");

            flminimo -= 3;
            flmaximo *= 2;
            doublenan *= 6;
            Console.WriteLine($"floats e doubles com overflow: {flminimo}  {flmaximo} {doublenan}");
            flminimo = flmaximo = 100.0f;
            Console.WriteLine($"floats e doubles com underflow: {flminimo == flmaximo + 0.001f}");       
        }
    }
}
