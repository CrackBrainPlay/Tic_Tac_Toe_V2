using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    public class BoardCreator
    { 
        private static int GetBoardWidth()
        {
            int boardWidth;
            do
            {
                Console.Clear();
                Console.WriteLine("Условия размера поля, оно не должно быть меньше 3 и боле 20");
                Console.Write("\nВведите размер поля, для игры: ");
                int.TryParse(Console.ReadLine(), out boardWidth);
            } while (boardWidth == 0 || boardWidth <= 2 || boardWidth >= 21);
            Console.Clear();
            return boardWidth;
        }

        public static BoardLayout Create()
        {
            int boardWidth = GetBoardWidth();
            return new BoardLayout(new PlayerSymbol[boardWidth, boardWidth]);
        }
    }
}
