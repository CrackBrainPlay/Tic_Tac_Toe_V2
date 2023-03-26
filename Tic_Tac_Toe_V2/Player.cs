using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    internal class Player
    {
        public char PlayerSymbol;
        public int Vertical;
        public int Horizontal;
        public int VerticalCoordinate;
        public int HorizontalСoordinate;
        public void AssignmentCoordinate(int FieldSize)
        {
            do
            {
                Console.Write("\nВведите координату по вертикали: ");
                int.TryParse(Console.ReadLine(), out Vertical);
            } while (Vertical == 0 || Vertical > FieldSize);
            Console.WriteLine();
            //Vertical = VerticalCoordinate;
            do
            {
                Console.Write("Введите координату по горизонтали: ");
                int.TryParse(Console.ReadLine(), out Horizontal);
            } while (Horizontal == 0 || Horizontal > FieldSize);
           // Horizontal = HorizontalСoordinate;
        }
    }
}
