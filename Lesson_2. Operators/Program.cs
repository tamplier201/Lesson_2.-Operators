using System;

namespace Lesson_2.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Переведем BYN в USD, EUR, RUB");
            Console.WriteLine("Сколько BYN переводим? Введите число");
            int BYN = Convert.ToInt32(Console.ReadLine());
            double USD = (double)BYN * 2.4361;
            double EUR = (double)BYN * 2.6502;
            double RUB = (double)BYN / 3.3188 * 100;
            Console.WriteLine("USD = " + USD + " EUR = " + EUR + " RUB = " + RUB);
            Console.Read();
        }
    }
}
