using System;

namespace ControllTask
{

    public static class Task_2
    {
        enum Days
        {
            Mon = 1, Tue, Wed, Thu, Fri, Sat, Sun
        }
        public static void MainTask()
        {
            Console.WriteLine(Enum.GetName(typeof(Days), 3));
        }
    }
}
