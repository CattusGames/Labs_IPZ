using System;

namespace ControllTask
{
    public class ConsoleInitialization
    {
        static void Main()
        {
            Console.WriteLine("\nНатисніть:\n'Enter' для атаки \n'Escape' для виходу");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            while (true)
            {
                Task_5.MainTask();
            }

        }

    }
}
