using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    internal class Game
    {

        public int Vertical;
        public int Horizontal;
        public static bool IsCheckCellFree(char[,] ValuesInPlayingField, int VerticalCoordinate, int HorizontalСoordinate)
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
        public static char[,] SetCellValue(int VerticalCoordinate, int HorizontalСoordinate, char[,] ValuesInPlayingField, char Symbol)
        {
            ValuesInPlayingField[VerticalCoordinate - 1, HorizontalСoordinate - 1] = Symbol;
            return ValuesInPlayingField;
        }
        /*public void InputCoordinate(int FieldSize)
        {
            do
            {
                Console.Write("\nВведите координату по вертикали: ");
                int.TryParse(Console.ReadLine(), out Vertical);
            } while (Vertical == 0 || Vertical > FieldSize);
            Console.WriteLine();
            do
            {
                Console.Write("Введите координату по горизонтали: ");
                int.TryParse(Console.ReadLine(), out Horizontal);
            } while (Horizontal == 0 || Horizontal > FieldSize);
        }*/

    }
}
