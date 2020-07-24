using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислим среднее арифметическое двух чисел");
            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a + b;
            double result = c / 2;
            Console.WriteLine("Результат = " + result);
            Console.ReadLine();
        }
    }
}
