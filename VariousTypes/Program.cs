using System;
using System.Text;

namespace VariousTypes
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Exercices Integers

            int x = -100;
            short x1 = 10;
            long x2 = 1_500_000L;
            uint ux = 100U;
            ulong ux2 = 2_500_100UL;

            Console.WriteLine($"Variável tipo int: {x}");
            Console.WriteLine($"Variável tipo short: {x1}");
            Console.WriteLine($"Variável tipo long: {x2}");
            Console.WriteLine($"Variável tipo uint: {ux}");
            Console.WriteLine($"Variável tipo ulong: {ux2}");
            Console.WriteLine("\n");

            // Exercices Chars

            char fist = '\u270A';
            char arrow = '\u2934';
            char c = '\u0063';
            char star = '\u2605';
            char hamSick = '\u262D';
            char square = '\u25A1';

            Console.WriteLine("Boletin de Voto\n");
            Console.WriteLine($"{square} PS {fist}");
            Console.WriteLine($"{square} PSD {arrow}");
            Console.WriteLine($"{square} BE {star}");
            Console.WriteLine($"{square} PCP {hamSick}");
            Console.WriteLine($"{square} CHEGA {c}");
            Console.WriteLine("\n");

            // Exercices Reals

            float y = 15.4023f;
            double y1 = 3.1415;
            decimal y2 = 1.50M;

            Console.WriteLine($"Variável tipo float: {y}");
            Console.WriteLine($"Variável tipo double: {y1}");
            Console.WriteLine($"Variável tipo decimal: {y2}");
            Console.WriteLine("\n");

            // Exercices bool

            bool bl1 = true;
            bool bl2 = 5 > 10;

            Console.WriteLine($"True é {bl1}");
            Console.WriteLine($"5 > 10 é {bl2}");
            Console.WriteLine("\n");

        }
    }
}
