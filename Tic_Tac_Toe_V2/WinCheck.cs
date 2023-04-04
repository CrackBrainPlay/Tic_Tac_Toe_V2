using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    static class WinCheck
    {
        private static int CounterVictory;
        public static bool IsWinCheck(PlayerSymbol[,] ValuesInPlayingField, PlayerSymbol Symbol)
        {
            for (int i = 0; i < ValuesInPlayingField.GetLength(0); i++)
                {
                    CounterVictory = 0;
                    for (int j = 0; j < ValuesInPlayingField.GetLength(1); j++)
                    {
                        if (ValuesInPlayingField[i, j] == Symbol)
                        {
                            CounterVictory++;
                        }
                        if (CounterVictory == ValuesInPlayingField.GetLength(0))
                        {
                            return true;
                        }
                    }
                }
                for (int i = 0; i < ValuesInPlayingField.GetLength(0); i++)
                {
                    CounterVictory = 0;
                    for (int j = 0; j < ValuesInPlayingField.GetLength(1); j++)
                    {
                        if (ValuesInPlayingField[j, i] == Symbol)
                        {
                            CounterVictory++;
                        }
                        if (CounterVictory == ValuesInPlayingField.GetLength(0))
                        {
                            return true;
                        }
                    }
                }
                CounterVictory = 0;
                for (int i = 0; i < ValuesInPlayingField.GetLength(0); i++)
                {
                    if (ValuesInPlayingField[i, i] == Symbol)
                    {
                        CounterVictory++;
                    }
                    if (CounterVictory == ValuesInPlayingField.GetLength(0))
                    {
                        return true;
                    }
                }
                CounterVictory = 0;
                for (int i = ValuesInPlayingField.GetLength(0) - 1; i >= 0; i--)
                {
                    if (ValuesInPlayingField[i, i] == Symbol)
                    {
                        CounterVictory++;
                    }
                    if (CounterVictory == ValuesInPlayingField.GetLength(0))
                    {
                        return true;
                    }
                }
                return false;
        }
    }
}
