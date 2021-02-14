using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, как тебя зовут?");//Выводит данные для пользоваетля и переходит на новую строку
            string name = Console.ReadLine();//водится имя пользователя и записывается в переменную name
            Console.WriteLine($"Привет {name} [{DateTime.Now}] ");
        }
    }
}
