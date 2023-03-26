using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    internal class Message
    {
        public static void Print(char Symbol)
        {
            Console.WriteLine("Game over!");
            Console.WriteLine($"\nПобедил {Symbol} игрок!!!!");
        }
    }
}
