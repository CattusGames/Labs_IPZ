using System;
//using System.Threading;

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
    public static class Task_5
    {
        private static Enemy enemy = new Enemy();
        public static void MainTask()
        {
            Console.WriteLine("Натисніть: \n'1' Щоб вибрати ніж \n'2' щоб вибрати рушницю \n'Enter' для атаки");
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.D1)
                {

                }
                else if (Console.ReadKey(true).Key == ConsoleKey.D2)
                {

                }
                else if(Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    
                }
                else
                {
                    return;
                }
            }

        }
    }
}
