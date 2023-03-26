using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    internal class MovePlayer
    {
        public char[,] ValuesField;
        public char[,] Move(int VerticalCoordinate, int HorizontalСoordinate, char[,] ValuesInPlayingField, char Symbol)
        {
            //bool IsCellFree = false;
            //do
            //{
                //Console.WriteLine($"\nХодит {Symbol} игрок!");
                //CoordinateAssignment(ValuesInPlayingField.GetLength(0), VerticalCoordinate, HorizontalСoordinate);
                //if (CheckIsCellFree(ValuesInPlayingField, VerticalCoordinate, HorizontalСoordinate))
                //{
                    //IsCellFree = true;
            ValuesInPlayingField[VerticalCoordinate - 1, HorizontalСoordinate - 1] = Symbol;
            ValuesField = ValuesInPlayingField;
                //}
            //} while (IsCellFree == false);
            return ValuesInPlayingField;
        }
    }
}
