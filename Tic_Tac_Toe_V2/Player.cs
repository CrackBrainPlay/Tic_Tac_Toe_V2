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
            m_Symbol = Symbol;
        }

        private readonly PlayerSymbol m_Symbol;

        public PlayerSymbol Symbol
        {
            get { return m_Symbol; }
        }
        private int m_Horizontal;
        private int m_Vertical;

        public void Move(BoardLayout Board) 
        {
            Message.OutputStepMessage(m_Symbol);
            do
            {
                InputCoordinate(Board.BoardWidth);
            }
            while (Board.IsCellFree(m_Vertical, m_Horizontal) == false);
            Board.SetCellValue(m_Vertical, m_Horizontal, m_Symbol);
        }

        private void InputCoordinate(int BoardWidth)
        {
            do
            {
                Console.Write("\nВведите координату по вертикали: ");
                _ = int.TryParse(Console.ReadLine(), out m_Vertical);
            } while (m_Vertical == 0 || m_Vertical > BoardWidth);
            Console.WriteLine();
            do
            {
                Console.Write("Введите координату по горизонтали: ");
                _ = int.TryParse(Console.ReadLine(), out m_Horizontal);
            } while (m_Horizontal == 0 || m_Horizontal > BoardWidth);
        }
    }
}