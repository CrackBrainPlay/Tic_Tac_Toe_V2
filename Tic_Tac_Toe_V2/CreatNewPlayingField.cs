using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    internal class CreatNewPlayingField
    {
        /*
        private int FieldSize;

        public int FIELDSIZE
        {
            get 
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Условия размера поля, оно не должно быть меньше 3 и боле 20");
                    Console.Write("\nВведите размер поля, для игры: ");
                    int.TryParse(Console.ReadLine(), out FieldSize);
                } while (FieldSize == 0 || FieldSize <= 2 || FieldSize >= 21);
                Console.Clear();
                return FieldSize;
            }
            set { FieldSize = value; }
        }
        
        private char[,] ValuesInPlayingField;

        public char[,] VALUESINPLAYUNDFIELD
        {
            private get 
            {
                ValuesInPlayingField = new char[FieldSize, FieldSize];
                return ValuesInPlayingField;
            }
            set { ValuesInPlayingField = value; }
        }*/

        private static int FieldSize;
        public static int GetFieldSize()
        {
            return FieldSize;
        }
        private static int SetFieldSize()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Условия размера поля, оно не должно быть меньше 3 и боле 20");
                Console.Write("\nВведите размер поля, для игры: ");
                int.TryParse(Console.ReadLine(), out FieldSize);
            } while (FieldSize == 0 || FieldSize <= 2 || FieldSize >= 21);
            Console.Clear();
            return FieldSize;
        }

        private static char[,] ValuesInPlayingField;

        public static char[,] GetValuesInPlayingField()
        {
            return ValuesInPlayingField;
        }
        public static char[,] SetValuesInPlayingField()
        {
            SetFieldSize();
            ValuesInPlayingField = new char[FieldSize, FieldSize];
            return ValuesInPlayingField;
        }
    }
}
