using System;

namespace ControllTask
{
    public class ScoreCounter 
    {
        private int score = 0;
        public void IncrementScore()
        {
            score++;
            Console.WriteLine("Ваш рахунок: " + score);
        }
    }

    public class Position
    {
        public int x;
        public int y;
    }
    public static class Task_5
    {
        private static Enemy enemy = new Enemy();
        private static Player player = new Player();
        private static Bullet bullet = new Bullet();

        private readonly static GameManager gameManager = new GameManager
        {
            playerPosition = player.position,
            enemyPosition = enemy.position,
            bulletPosition = bullet.position
        };

        

        public static void MainTask()
        {
            if (enemy != null)
            {
                enemy.Move();
            }
            else
            {
                return;
            }

            gameManager.Start();

            Input();

            enemy.onDead += gameManager.scoreCounter.IncrementScore;
            enemy.onDead += () => { enemy = null; enemy = new Enemy(); };
            
        }

        private static void Input()
        {
            
            if (Console.ReadKey(true).Key == ConsoleKey.W)
            {
                player.Move(-1 , 0);
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.A)
            {
                player.Move(0 , -1);
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                player.Move(1 , 0);
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.D)
            {
                player.Move(0 , 1);
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                return;
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }
    }
}
