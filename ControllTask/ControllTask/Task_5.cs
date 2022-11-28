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
        private static ScoreCounter scoreCounter = new ScoreCounter();
        private static string[,] field = new string[100,50];
        private static bool start = false;
        public static void MainTask()
        {
            if (start == false)
            {
                SetArray(field);
                start = true;
            }
            DrawArray(field);
            Input();
            enemy.onDead += scoreCounter.IncrementScore;
            enemy.onDead += () => { enemy = null; enemy = new Enemy();};

        }
        private static void SetArray(string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = " ";
                }
            }
        }
        private static void DrawArray(string[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                }
            }
        }
        private static void Input()
        {
            Console.WriteLine("Натисніть: \n'1' Щоб вибрати ніж \n'2' щоб вибрати рушницю \n'Enter' для атаки \n'Escape' для виходу");
            if (Console.ReadKey(true).Key == ConsoleKey.D1)
            {

            }
            else if (Console.ReadKey(true).Key == ConsoleKey.D2)
            {

            }
            else if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {

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
