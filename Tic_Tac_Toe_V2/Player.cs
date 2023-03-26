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

        public int AssignmentVerticalCoordinate(int FieldSize)
        {
            int VerticalCoordinate;
            do
            {
                Console.Write("\nВведите координату по вертикали: ");
                int.TryParse(Console.ReadLine(), out VerticalCoordinate);
            } while (VerticalCoordinate == 0 || VerticalCoordinate > FieldSize);
            Console.WriteLine();
            Vertical = VerticalCoordinate;
            return VerticalCoordinate;
        }
        public int AssignmentHorizontalСoordinate(int FieldSize)
        {
            int HorizontalСoordinate;
            do
            {
                Console.Write("Введите координату по горизонтали: ");
                int.TryParse(Console.ReadLine(), out HorizontalСoordinate);
            } while (HorizontalСoordinate == 0 || HorizontalСoordinate > FieldSize);
            Horizontal = HorizontalСoordinate;
            return HorizontalСoordinate;
        }
    }
}
