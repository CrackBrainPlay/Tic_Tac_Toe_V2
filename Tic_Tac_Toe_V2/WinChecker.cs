using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    static class WinChecker
    {
        public static bool IsWin(BoardLayout Board, Player Player)
        {
            int victoryCounter;
            for (int i = 0; i < Board.Board.GetLength(0); i++)
                {
                    victoryCounter = 0;
                    for (int j = 0; j < Board.Board.GetLength(1); j++)
                    {
                        if (Board.Board[i, j] == Player.Symbol)
                        {
                            victoryCounter++;
                        }
                        if (victoryCounter == Board.Board.GetLength(0))
                        {
                            return true;
                        }
                    }
                }
                for (int i = 0; i < Board.Board.GetLength(0); i++)
                {
                    victoryCounter = 0;
                    for (int j = 0; j < Board.Board.GetLength(1); j++)
                    {
                        if (Board.Board[j, i] == Player.Symbol)
                        {
                            victoryCounter++;
                        }
                        if (victoryCounter == Board.Board.GetLength(0))
                        {
                            return true;
                        }
                    }
                }
                victoryCounter = 0;
                for (int i = 0; i < Board.Board.GetLength(0); i++)
                {
                    if (Board.Board[i, i] == Player.Symbol)
                    {
                        victoryCounter++;
                    }
                    if (victoryCounter == Board.Board.GetLength(0))
                    {
                        return true;
                    }
                }
                victoryCounter = 0;
                for (int i = Board.Board.GetLength(0) - 1; i >= 0; i--)
                {
                    if (Board.Board[i, i] == Player.Symbol)
                    {
                        victoryCounter++;
                    }
                    if (victoryCounter == Board.Board.GetLength(0))
                    {
                        return true;
                    }
                }
                return false;
        }
    }
}
