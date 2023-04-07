using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    public class BoardLayout
    {
        public BoardLayout(PlayerSymbol[,] Board) 
        {
            BoardWidth = Board.GetLength(0);
            this.Board = Board;
        }

        public int BoardWidth { get; }

        public PlayerSymbol[,] Board { get; }

        public bool IsCellFree( int Vertical, int Horizontal)
        {
            return (Board[Vertical - 1 , Horizontal - 1] == 0);
        }
        public void SetCellValue( int Vertical, int Horizontal, PlayerSymbol Symbol)
        {
            Board[Vertical - 1, Horizontal - 1] = Symbol;
        }
    }
}
