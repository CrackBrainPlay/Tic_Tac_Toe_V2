﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_V2
{
    internal class CreatNewPlayingField
    {
        private int FieldSize;
        private char[,] ValuesInPlayingField;
        public int NewPlayingField()
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
        public char[,] CreatField(int FieldSize)
        {
            ValuesInPlayingField = new char[FieldSize, FieldSize];
            return ValuesInPlayingField;
        }
    }
}