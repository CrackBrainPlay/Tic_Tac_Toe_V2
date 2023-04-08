using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    public static class WinCheck2
    {
        private static bool IsWinCheckRevers(BoardLayout Board, int Vertical, int Horizontal, int diff1, int diff2)
        {
            Vertical--;
            Horizontal--;
            int victoryCounter = 0;
            int quantity = 3;
            int boardLenght = Board.Board.GetLength(0);
            PlayerSymbol symbol = Board.Board[Vertical, Horizontal];
            bool leftWalk = false;
            bool rightWalk = false;
            for (int j = 0; j < quantity; j++)
            {
                int leftVertical = Vertical  - j * diff1;
                int leftHorizontal = Horizontal  - j * diff2;
                int rightVertical = Vertical  + j * diff1;
                int rightHorizontal = Horizontal  + j * diff2;
                if (leftVertical > -1 && leftVertical < boardLenght && leftHorizontal > -1 && leftHorizontal < boardLenght && leftWalk == false)
                {
                    if (Board.Board[leftVertical, leftHorizontal] == 0)
                    {
                        leftWalk = true;
                    }
                    else if (Board.Board[leftVertical, leftHorizontal] == symbol)
                    {
                        victoryCounter++;
                    }
                }
                if (rightVertical > -1 && rightVertical < boardLenght && rightHorizontal > -1 && rightHorizontal < boardLenght && rightWalk == false)
                {
                    if (Board.Board[rightVertical, rightHorizontal] == 0)
                    {
                        rightWalk = true;
                    }
                    else if (Board.Board[rightVertical, rightHorizontal] == symbol)
                    {
                        victoryCounter++;
                    }
                }
                if (victoryCounter > quantity)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsWinCheck(BoardLayout Board, Player Player)
        {
            return IsWinCheckRevers(Board, Player.Vertical, Player.Horizontal, -1, 1) || IsWinCheckRevers(Board, Player.Vertical, Player.Horizontal, 0, 1) || IsWinCheckRevers(Board, Player.Vertical, Player.Horizontal, 1, 1) || IsWinCheckRevers(Board, Player.Vertical, Player.Horizontal, 1, 0);
        }
    }
}
