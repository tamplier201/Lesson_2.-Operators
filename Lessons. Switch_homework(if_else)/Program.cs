using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Switch_homework_if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это простенький калькулятор, осуществляющий простейшие математические действия c двумя заданными числами.");
            Console.WriteLine("Какое действие вы хотите произвести? Введите матемитический знак (+, -, *, /)");
            string mathOperator = Console.ReadLine();
            Console.WriteLine("Введите первое число");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            if (mathOperator == "+")
            {
                Console.WriteLine("Результат: ");
                Console.WriteLine(firstNum + secondNum);
                Console.ReadLine();
            }
            if (mathOperator == "-")
            {
                Console.WriteLine("Результат: ");
                Console.WriteLine(firstNum - secondNum);
                Console.ReadLine();
            }
            if (mathOperator == "*")
            {
                Console.WriteLine("Результат: ");
                Console.WriteLine(firstNum * secondNum);
                Console.ReadLine();
            }
            if (mathOperator == "/")
            {
                Console.WriteLine("Результат: ");
                Console.WriteLine(firstNum / secondNum);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ошибка");
                Console.ReadLine();
            }
        }
    }
}
