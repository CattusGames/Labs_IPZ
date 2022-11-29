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
