using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    public class Field
    {
        public Field(char[,] PlayingField, int FieldSize) 
        {
            this.FieldSize = FieldSize;
            this.PlayingField = PlayingField;
        }
        public int FieldSize { get; set; }

        public char[,] PlayingField { get; set; }
    }
}
