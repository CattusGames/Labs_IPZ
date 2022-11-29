using System;
using System.Timers;

namespace ControllTask
{
    public class Enemy : IDamagable, IMovable
    {

        private int health = 4;
        public event Action onDead;
        
        public Position position { get; set; } = new Position { x = 5, y = 49 };
        public float speed { get; set; } = 2f;
        Timer timer = new Timer() { Interval = 1};
        private readonly Random random = new Random();
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
            /* timer.Start();
             timer.Interval = speed;
             timer.Elapsed += (o, e) =>
             {

             };*/
            if (position.x<=0||position.x>=10)
            {

            }
            else if(position.y <= 0 || position.x >= 50)
            {

            }
            else
            {
                position.x += random.Next(-1, 1);
                position.y += random.Next(-1, 1);
            }

        }
        public void Move(int x, int y){}
    }
}
