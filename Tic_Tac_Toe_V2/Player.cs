using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    enum SymbolPlayer
    {
        X,
        O
    }
    internal class Player
    {
        public Player(char NamePlayer)
        {
            this.NamePlayer = NamePlayer;

        }
        private char NamePlayer;
        private int Vertical;
        private int Horizontal;
        public void InputCoordinate(int FieldSize)
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
        }
        public char NamePlayerReturn()
        {
            return NamePlayer;
        }
        public int HorizontalReturn()
        {
            return Horizontal;
        }
        public int VerticalReturn()
        {
            return Vertical;
        }

    }
}
