using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    internal class WinCheck2
    {

        private static int CounterVictory;
        public static bool IsWinCheck(BoardLayout NewField, Player NewPlayer)
        {
            for (int i = 0; i < NewField.Board.GetLength(0); i++)
            {
                CounterVictory = 0;
                for (int j = 0; j < NewField.Board.GetLength(1); j++)
                {
                    if (NewField.Board[i, j] == NewPlayer.Symbol)
                    {
                        CounterVictory++;
                    }
                    if (CounterVictory == NewField.Board.GetLength(0))
                    {
                        return true;
                    }
                }
            }
            for (int i = 0; i < NewField.Board.GetLength(0); i++)
            {
                CounterVictory = 0;
                for (int j = 0; j < NewField.Board.GetLength(1); j++)
                {
                    if (NewField.Board[j, i] == NewPlayer.Symbol)
                    {
                        CounterVictory++;
                    }
                    if (CounterVictory == NewField.Board.GetLength(0))
                    {
                        return true;
                    }
                }
            }
            CounterVictory = 0;
            for (int i = 0; i < NewField.Board.GetLength(0); i++)
            {
                if (NewField.Board[i, i] == NewPlayer.Symbol)
                {
                    CounterVictory++;
                }
                if (CounterVictory == NewField.Board.GetLength(0))
                {
                    return true;
                }
            }
            CounterVictory = 0;
            for (int i = NewField.Board.GetLength(0) - 1; i >= 0; i--)
            {
                if (NewField.Board[i, i] == NewPlayer.Symbol)
                {
                    CounterVictory++;
                }
                if (CounterVictory == NewField.Board.GetLength(0))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
