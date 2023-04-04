using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    public static class PrintField
    {
        public static void Print(Field Field1)
        {
            Console.Clear();
            Console.Write("  ");
            for (int j = 0; j < Field1.PlayingField.GetLength(0); j++)
            {
                    Console.Write($" {j + 1} ");
            }
            Console.WriteLine();
            for (int i = 0; i < Field1.PlayingField.GetLength(0); i++)
            {
                Console.Write($"{i + 1} ");
                for (int j = 0; j < Field1.PlayingField.GetLength(0); j++)
                {
                    if (Field1.PlayingField[i, j] == 0)
                    {
                        Console.Write("[ ]");
                    }
                    else
                    {
                        Console.Write($"[{Field1.PlayingField[i, j]}]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
