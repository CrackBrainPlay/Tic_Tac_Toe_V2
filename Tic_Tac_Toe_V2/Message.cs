using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    static class Message
    {
        private const string GAME_OVER_MSG = "Game over!";
        private const string PLAYER_WINS_MSG = "Победил игрок!!!";
        public static void OutputWinMessage(PlayerSymbol Symbol)
        {
            Console.WriteLine(GAME_OVER_MSG);
            Console.WriteLine($"{PLAYER_WINS_MSG} {Symbol}");
        }
        public static void OutputStepMessage(PlayerSymbol Symbol)
        {
            Console.WriteLine($"\nХодит {Symbol}");
        }
    }
}
