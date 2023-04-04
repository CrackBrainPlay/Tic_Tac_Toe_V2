using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    public static class PrintField
    {
        public static void Print(PlayerSymbol[,] ValuesInPlayingField)
        {
            Console.Clear();
            Console.Write("  ");
            for (int j = 0; j < ValuesInPlayingField.GetLength(0); j++)
            {
                    Console.Write($" {j + 1} ");
            }
            Console.WriteLine();
            for (int i = 0; i < ValuesInPlayingField.GetLength(0); i++)
            {
                Console.Write($"{i + 1} ");
                for (int j = 0; j < ValuesInPlayingField.GetLength(0); j++)
                {
                    if (ValuesInPlayingField[i, j] == 0)
                    {
                        Console.Write("[ ]");
                    }
                    else
                    {
                        Console.Write($"[{ValuesInPlayingField[i, j]}]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
