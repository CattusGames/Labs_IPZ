using System;

namespace ControllTask
{
    public static class Task_1
    {
        static int a;

        public static void MainTask()
        {

            Console.WriteLine("Введіть число : ");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
