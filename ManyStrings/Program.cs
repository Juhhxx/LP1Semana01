using System;

namespace ManyStrings
{
    class Program
    {
        static void Main()
        {
            string s = "Era uma vez\nUma pessoa\nChamada Afonso\n\t \uA231";
            string chessboardW = "\u2656 \u2658 \u2657 \u2654 \u2655 \u2657 \u2658 \u2656";
            char pondW = '\u2659';
            string chessboardW2 = $"{pondW} {pondW} {pondW} {pondW} {pondW} {pondW} {pondW} {pondW}";
  
            Console.WriteLine(s);
            Console.WriteLine(chessboardW);
            Console.WriteLine(chessboardW2);
            Console.WriteLine("\n");

        }
    }
}
