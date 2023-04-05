using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    public static class Renderer
    {
        public static void RenderBoard(BoardLayout Board)
        {
            Console.Clear();
            Console.Write("  ");
            for (int j = 0; j < Board.Board.GetLength(0); j++)
            {
                    Console.Write($" {j + 1} ");
            }
            Console.WriteLine();
            for (int i = 0; i < Board.Board.GetLength(0); i++)
            {
                Console.Write($"{i + 1} ");
                for (int j = 0; j < Board.Board.GetLength(0); j++)
                {
                    if (Board.Board[i, j] == 0)
                    {
                        Console.Write("[ ]");
                    }
                    else
                    {
                        Console.Write($"[{Board.Board[i, j]}]");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
