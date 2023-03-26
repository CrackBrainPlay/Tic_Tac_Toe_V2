using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    internal class MovePlayer
    {
        public static char[,] Move(int VerticalCoordinate, int HorizontalСoordinate, char[,] ValuesInPlayingField, char Symbol)
        {
            ValuesInPlayingField[VerticalCoordinate - 1, HorizontalСoordinate - 1] = Symbol;
            return ValuesInPlayingField;
        }
    }
}
