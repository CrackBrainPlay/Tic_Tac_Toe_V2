using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    public class CheckIsCellFree
    {
        public bool IsCheckCellFree(char[,] ValuesInPlayingField, int VerticalCoordinate, int HorizontalСoordinate)
        {
            if (ValuesInPlayingField[VerticalCoordinate - 1, HorizontalСoordinate - 1] == '\0')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
