using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllTask.UI
{
    public class UISettings
    {
        public List<Rect> choords = new List<Rect>()
        {
            new Rect(){left = 0, top = 0, textColor = ConsoleColor.Blue, backgroundColor = ConsoleColor.White},// for gamecore
            new Rect(){left = 0, top = 50, textColor = ConsoleColor.Black, backgroundColor = ConsoleColor.White }, // for info
            new Rect(){left = 50, top = 50, textColor = ConsoleColor.DarkGreen, backgroundColor = ConsoleColor.White}, // for weapon
            new Rect(){left = 100, top = 50, textColor = ConsoleColor.Red, backgroundColor = ConsoleColor.White} // for speech
        };

    }
}
