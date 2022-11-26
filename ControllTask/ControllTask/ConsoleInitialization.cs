using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllTask.UI;
namespace ControllTask
{
    public class ConsoleInitialization : CommonUpdate
    {
        static void Main()
        {
            Initialization();
            Console.ReadKey();
        }
        public static void Write()
        {
            Console.WriteLine(0);
        }
        private static void Initialization()
        {
            //Update += Write();
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
