using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа, рассчитаем их сумму и произведение");
            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            double c = Convert.ToDouble(Console.ReadLine());
            double resultSUM = a + b + c;
            double resultMULT = a * b * c;
            Console.WriteLine("Результат суммы = " + resultSUM);
            Console.WriteLine("Результат умножения = " + resultMULT);
            Console.ReadLine();
        }
    }
}
