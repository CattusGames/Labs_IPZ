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

        

        public async static void MainTask()
        {
            if (enemy != null)
            {
                Timer timer = new Timer((object o) => { enemy.Move(); }, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(0.5f));
                
            }
            gameManager.Start();

            await Task.Run(() =>
            {
                Input();
            });
            enemy.onDead += gameManager.scoreCounter.IncrementScore;
            enemy.onDead += () => { enemy = null; enemy = new Enemy(); };
            
        }

        private static void Input()
        {
            Console.SetCursorPosition(1, 2);
            if (Console.ReadKey(true).Key == ConsoleKey.W)
            {
                player.Move(-1, 0);
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.A)
            {
                player.Move(0, -1);
                player.right = false;
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                player.Move(1, 0);
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.D)
            {
                player.Move(0, 1);
                player.right = true;
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                bullet.Move(player.position.x, player.position.y,player.right);
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
