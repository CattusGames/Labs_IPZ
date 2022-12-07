using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace ControllTask
{
    public class GameManager
    {
        public ScoreCounter scoreCounter = new ScoreCounter();
        public Field field = new Field();
        public Position playerPosition;
        public Position enemyPosition;

        public void Start()
        {
                field.SetArray(playerPosition, enemyPosition);
                Console.SetCursorPosition(0, 0);
                field.DrawArray();
        }
    }
}
