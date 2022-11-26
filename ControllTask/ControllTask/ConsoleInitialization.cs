using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllTask
{
    public class ConsoleInitialization
    {
        static void Main()
        {
            SetConsoleColor(ConsoleColor.White, ConsoleColor.Black);
            Task_4.MainTask();
            Console.ReadKey();
        }

        public static void SetConsoleColor(ConsoleColor backgroundColor, ConsoleColor textColor)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = textColor;
            Console.Clear();
        }
        public void CursorCounter(int left, int top)
        {
            Console.SetCursorPosition(left,top);
        }
    }
}
