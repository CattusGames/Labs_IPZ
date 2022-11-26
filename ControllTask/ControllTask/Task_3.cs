using System;

namespace ControllTask
{
    public class Rectangle
    {
        //приватні поля
        private static uint a;
        private static uint b;
        private static string n;

        //сторона А
        public static uint SideA
        {
            get { return a; }
            set
            {
                //перевірка значення перед присвоєнням
                if (value > 0)
                    a = value;
                else
                    Console.WriteLine("Помилка А == 0");
            }
        }

        //сторона В
        public static uint SideB
        {
            get { return b; }
            set
            {
                //перевірка значення перед присвоєнням
                if (value > 0)
                    b = value;
                else
                    Console.WriteLine("Помилка В == 0");
            }
        }

        //назва прямокутника
        //властивість з доступом тільки для запису
        public static string Name
        {
            set { n = value; }
        }

        //площа прямокутника
        //властивість з доступом тільки для читання
        public static uint Area
        {
            //обробка перед поверненням
            get { return a * b; }
        }

        //метод виводить на екран дані про фігуру
        public static void Print()
        {
            Console.WriteLine($"{n} {a}x{b} Area = {Area}");
        }
    }
    public static class Task_3
    {

        public static void MainTask()
        {
            Rectangle.Name = "ABCD";
            Rectangle.SideA = 0; //Виводиться повідомлення "Помилка А == 0"
            Rectangle.SideA = 9;
            Rectangle.SideB = 7;
            Rectangle.Print(); //ABCD 9x7 Area = 63
            Console.ReadLine();
        }

    }
}