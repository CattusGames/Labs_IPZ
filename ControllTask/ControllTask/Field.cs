using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllTask
{
    public class Field
    {
        private string[,] field = new string[10, 50];

        public void DrawArray()
        {
            
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write("{0,2}", field[i, j]);
                }
                Console.WriteLine();

            }
            
        }
        public void SetArray(Position player, Position enemy, Position bullet)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = "_";
                }
            }

            if (bullet.x>field.GetLength(0) || bullet.y > field.GetLength(1) || bullet.x < 0 || bullet.y<0)
            {
                
            }
            else if (player.x > field.GetLength(0) || player.y > field.GetLength(1) || player.x < 0 || player.y < 0)
            {
                
            }
            else if (enemy.x > field.GetLength(0) || enemy.y > field.GetLength(1) || enemy.x < 0 || enemy.y < 0)
            {
                
            }
            else
            {
                field[player.x, player.y] = "O";
                field[enemy.x, enemy.y] = "*";
                field[bullet.x, bullet.y] = "o";
            }

        }
    }
}
