﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllTask
{
    public class Field
    {
        private string[,] field = new string[10, 50];
        public event Action OnPosition;

        public void DrawArray()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write("{0,2}", field[i, j]);
                }
                Console.WriteLine();

            }

        }
        public void SetArray(Position player, Position enemy)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = ".";
                }
            }
            field[player.x, player.y] = "O";
            field[enemy.x, enemy.y] = "*";

            if (player.x == enemy.x && player.y == enemy.y && enemy !=null)
            {
                OnPosition?.Invoke();
            }
        }
    }
}