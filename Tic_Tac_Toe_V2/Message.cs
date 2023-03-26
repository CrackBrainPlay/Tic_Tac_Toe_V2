using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    internal class Message
    {
        public static void PrintWin(char Symbol)
        {
            Console.WriteLine("Game over!");
            Console.WriteLine($"\nПобедил {Symbol} игрок!!!!");
        }
        public static void PrintMove(char Symbol)
        {
            Console.WriteLine($"\nХодит {Symbol}");
        }
    }
}
