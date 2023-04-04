using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    static class Message
    {
        private const string GAME_OVER = "Game over!";
        private const string PLAYER_IS_WIN = "Победил игрок!!!";
        public static void PrintWin(PlayerSymbol Symbol)
        {
            Console.WriteLine(GAME_OVER);
            Console.WriteLine($"{PLAYER_IS_WIN} {Symbol}");
        }
        public static void PrintMove(PlayerSymbol Symbol)
        {
            Console.WriteLine($"\nХодит {Symbol}");
        }
    }
}
