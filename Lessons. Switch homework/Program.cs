using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Switch_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это маленький калькулятор. Здесь можно сделать сложение, вычитание, умножение и деление двух целочисленных чисел.");
            Console.WriteLine("Какое вы хотите совершить действие? Пожалуйста, введите символ действия (+ или - или * или /)");
            string operation = Console.ReadLine();
            Console.WriteLine("Введите число 1");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            double secondNum = double.Parse(Console.ReadLine());
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Результат:");
                    Console.WriteLine(firstNum + secondNum);
                    Console.ReadLine();
                    break;
                case "-":
                    Console.WriteLine("Результат:");
                    Console.WriteLine(firstNum - secondNum);
                    Console.ReadLine();
                    break;
                case "*":
                    Console.WriteLine("Результат:");
                    Console.WriteLine(firstNum * secondNum);
                    Console.ReadLine();
                    break;
                case "/":
                    Console.WriteLine("Результат:");
                    Console.WriteLine(firstNum / secondNum);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Не получилось произвести действие");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
