using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllTask.UI;
namespace ControllTask
{
    public class ConsoleInitialization
    {
        static int i = 0;
        static void Main()
        {
            while (true)
            {
                Task_5.MainTask();
            }
        }
        public static void Write()
        {
            Console.WriteLine(0);
        }
        public void SetConsoleColor(Rect rect)
        {
            Console.BackgroundColor = rect.backgroundColor;
            Console.ForegroundColor = rect.textColor;
        }
        public void CursorCounter(int left, int top)
        {
            Console.SetCursorPosition(left,top);
        }

    }
}
