using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    public class Player
    {
        public Player(PlayerSymbol Symbol )
        {
            _Symbol = Symbol;
        }

        private readonly PlayerSymbol _Symbol;

        public PlayerSymbol Symbol
        {
            get { return _Symbol; }
        }
        private int _Horizontal;
        private int _Vertical;

        public void Move(Field Field1) 
        {
            Message.PrintMove(_Symbol);
            do
            {
                InputCoordinate(Field1.FieldSize);
            }
            while (Field1.IsCheckCellFree(_Vertical, _Horizontal) == false);
            Field1.SetCellValue(_Vertical, _Horizontal, _Symbol);
        }

        private void InputCoordinate(int FieldSize)
        {
            do
            {
                Console.Write("\nВведите координату по вертикали: ");
                _ = int.TryParse(Console.ReadLine(), out _Vertical);
            } while (_Vertical == 0 || _Vertical > FieldSize);
            Console.WriteLine();
            do
            {
                Console.Write("Введите координату по горизонтали: ");
                _ = int.TryParse(Console.ReadLine(), out _Horizontal);
            } while (_Horizontal == 0 || _Horizontal > FieldSize);
        }
    }
}