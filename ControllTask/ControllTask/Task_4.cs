using System;


namespace ControllTask
{
    public abstract class Weapon
    {
        public abstract int damagePower {get;set;}

        public abstract int Attack();

    }
    class Knife : Weapon
    {
        public override int damagePower { get; set; } = 1;
        public override int Attack()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Knife Damage :" + damagePower);
            return damagePower;
        }
    }
    class Rifle : Weapon
    {
        public override int damagePower { get; set; } = 2;

        public override int Attack()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Rifle Damage :" + damagePower);
            return damagePower;
        }
    }
    interface IDamagable
    {
        void GetDamage(int bitePower);
    }
    public class Enemy : IDamagable {

        public int health = 4;
        int cursorTopPosition = 0;
        public void GetDamage(int bitePower)
        {
            
            if (health<=0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Enemy Dead");

            }
            else
            {

                Console.SetCursorPosition(100, cursorTopPosition);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Ouch");
                health -= bitePower;
                cursorTopPosition++;
            }

        }
    }
    public static class Task_4
    {
        private static Enemy enemy = new Enemy();
        private static Knife knife = new Knife();
        private static Rifle rifle = new Rifle();
        public static void MainTask()
        {
            Console.WriteLine("Натисніть: \n'K' для атаки ножем \n'R' для атаки рушницею");
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.K)
                {
                    enemy.GetDamage(knife.Attack());
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.R)
                {
                    enemy.GetDamage(rifle.Attack());
                }
                else
                {
                    return;
                }
            }

        }
    }
}
