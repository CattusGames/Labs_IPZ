using System;
using System.Timers;

namespace ControllTask
{
    public class Enemy : IDamagable, IMovable
    {

        private int health = 1;
        public event Action onDead;

        public Position position { get; set; } = new Position { x = 8, y = 40 };
        public float speed { get; set; } = 0.8f;
        private Random random = new Random();

        public void GetDamage(int bitePower)
        {

            if (health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Enemy Dead");
                onDead?.Invoke();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Ouch");
                health -= bitePower;
            }

        }
        public void Move()
        {
                position.x = CheckPosition(position).x;
                position.y = CheckPosition(position).y;
        }
        private Position CheckPosition(Position currentPosition)
        {
            Position pos = new Position { x = currentPosition.x, y = currentPosition.y };
            pos.x += (random.Next(0, 2) == 1) ? 1 : -1;
            pos.y += (random.Next(0, 2) == 1) ? 1 : -1;

            if ( (pos.x <= 0) || (pos.y <= 0) || (pos.x  >= 10 ) || (pos.y >= 50) )
            {
                return currentPosition;
            }
            else
            {
                return pos;
            }
        }
        public void Move(int x, int y){}
    }
}
