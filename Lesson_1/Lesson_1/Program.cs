using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, как тебя зовут?");
            string name = Console.ReadLine();
            
            Console.WriteLine($"Привет {name} [{DateTime.Now}] ");            
        }
    }
}
