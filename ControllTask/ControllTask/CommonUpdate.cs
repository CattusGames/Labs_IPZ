﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ControllTask
{
    
    public abstract class CommonUpdate
    {
        public static event EventHandler Update;
        private static Timer timer = new Timer(100);
        static void Main()
        {
            timer.Elapsed += async (sender, e) => await Task.Run(() =>
            {
                Update.Invoke();
            });
        }
    }
}
