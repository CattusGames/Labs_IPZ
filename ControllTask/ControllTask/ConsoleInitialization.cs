using System;

namespace ControllTask
{
    public class ConsoleInitialization
    {
        static void Main()
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("\nНатисніть:\n'Enter' для старту \n'Escape' для виходу \n'1' щоб додати нового ворога \n'2' щоб почати заново");

            Task_5.MainTask();

        }

    }
}
