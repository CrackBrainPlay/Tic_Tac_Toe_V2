using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    public class Field
    {
        public Field(PlayerSymbol[,] PlayingField, int FieldSize) 
        {
            this.FieldSize = FieldSize;
            this.PlayingField = PlayingField;
        }
        
        public int FieldSize { get; set; }
        
        public PlayerSymbol[,] PlayingField { get; set; }

        public bool IsCheckCellFree( int Vertical, int Horizontal)
        {
            return (PlayingField[Vertical - 1, Horizontal - 1] == 0);
        }
        public void SetCellValue(int Vertical, int Horizontal, PlayerSymbol Symbol)
        {
            PlayingField[Vertical - 1, Horizontal - 1] = Symbol;
        }
    }
}
