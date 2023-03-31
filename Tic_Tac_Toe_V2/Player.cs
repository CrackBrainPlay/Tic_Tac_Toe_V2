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
        public char NamePlayer { get; }
        private int _Horizontal;

        public int Horizontal
        {
            get { return _Horizontal; }
            set { _Horizontal = value; }
        }

        private int _Vertical;

        public int Vertical
        {
            get { return _Vertical; }
            set { _Vertical = value; }
        }

        public void InputCoordinate(int FieldSize)
        {
            do
            {
                Console.Write("\nВведите координату по вертикали: ");
                int.TryParse(Console.ReadLine(), out _Vertical);
            } while (_Vertical == 0 || _Vertical > FieldSize);
            Console.WriteLine();
            do
            {
                Console.Write("Введите координату по горизонтали: ");
                int.TryParse(Console.ReadLine(), out _Horizontal);
            } while (_Horizontal == 0 || _Horizontal > FieldSize);
        }
        /*public char NamePlayerReturn()
        {
            return NamePlayer;
        }*/
        /*public int HorizontalReturn()
        {
            return Horizontal;
        }
        public int VerticalReturn()
        {
            return Vertical;
        }*/

    }
}
