using System;
using System.Threading;
using System.Threading.Tasks;

namespace ControllTask
{
    
    public class ScoreCounter 
    {
        private int score = 0;
        public void IncrementScore()
        {
            score++;
            Console.SetCursorPosition(1,13);
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

        private static DateTime lastMeasuredTime = DateTime.Now;
        private static double desiredFrameTime = 1000.0 / 24.0;
        private static bool init = false;
        private static bool start = false;
        private static bool isCatch = false;
        private readonly static GameManager gameManager = new GameManager
        {
            playerPosition = player.position,
            enemyPosition = enemy.position,
        };

        

        public static void MainTask()
        {
            while (true)
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    Input(key);
                }
                if ((DateTime.Now - lastMeasuredTime).TotalMilliseconds >= desiredFrameTime)
                {
                    if (init == false)
                    {
                        Initialization();
                        init = true;
                    }
                    if (start == true)
                    {
                        Timer timer1 = new Timer((object o) =>
                        {
                            if (!isCatch)
                            {
                                start = false;
                                Console.Clear();
                                Console.WriteLine("Гру закінчено");
                            }
                        }, null, TimeSpan.FromSeconds(10f), TimeSpan.FromSeconds(1f));
                        Timer timer = new Timer((object o) => { enemy.Move(); }, null, TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(5f));
                        gameManager.Start();
                        lastMeasuredTime = DateTime.Now;
                    }
                }
            }  
        }
        private static void Initialization()
        {
            gameManager.field.OnPosition += () => { enemy.GetDamage(1); isCatch = true; };
            enemy.onDead += () => { enemy.health = 1; gameManager.scoreCounter.IncrementScore(); isCatch = false; };
        }
        private static void Input(ConsoleKeyInfo consoleKey)
        {
            if (consoleKey.Key == ConsoleKey.W)
            {
                player.Move(-1, 0);
            }
            else if (consoleKey.Key == ConsoleKey.A)
            {
                player.Move(0, -1);
                player.right = false;
            }
            else if (consoleKey.Key == ConsoleKey.S)
            {
                player.Move(1, 0);
            }
            else if (consoleKey.Key == ConsoleKey.D)
            {
                player.Move(0, 1);
                player.right = true;
            }
            else if (consoleKey.Key == ConsoleKey.Enter)
            {
                start = true;
            }
            else if (consoleKey.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
