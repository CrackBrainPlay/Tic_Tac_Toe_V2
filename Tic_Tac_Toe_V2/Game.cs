using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    class Game
    {
        public static bool MakeStep(BoardLayout Board, Player Player)
        {
            Player.Move(Board);
            Renderer.RenderBoard(Board);
            if (WinCheck2.IsWinCheck(Board, Player))
            {
                Message.OutputWinMessage(Player.Symbol);
                return true;
            }
            return false;
        }

    }
}
