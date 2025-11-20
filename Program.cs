

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                float one, two, result;
                string input;
                char sign;

                Console.Clear();
                Console.WriteLine("Добро пожаловать в калькулятор");
                Console.WriteLine("Введите два числа и знак действия (+, -, *, /).");
                Console.WriteLine("Для выхода введите 'w'.");

                Console.Write("Введите первое число: ");
                input = Console.ReadLine();
                if (IsExit(input)) return;
                while (!float.TryParse(input, out one))
                {
                    Console.Write("Ошибка! Введите корректное число или 'w' для выхода: ");
                    input = Console.ReadLine();
                    if (IsExit(input)) return;
                }

              
                Console.Write("Введите знак действия (+, -, *, /): ");
                while (true)
                {
                    input = Console.ReadLine();
                    if (IsExit(input)) return;

                    switch (input)
                    {
                        case "+":
                        case "-":
                        case "*":
                        case "/":
                            sign = input[0]; 
                            break;
                        default:
                            Console.Write("Ошибка! Введите корректный знак (+, -, *, /) или 'w' для выхода: ");
                            continue; 
                    }
                    break; 
                }

              
                Console.Write("Введите второе число: ");
                input = Console.ReadLine();
                if (IsExit(input)) return;
                while (!float.TryParse(input, out two))
                {
                    Console.Write("Ошибка! Введите корректное число или 'w' для выхода: ");
                    input = Console.ReadLine();
                    if (IsExit(input)) return;
                }

             
                if (sign == '/' && two == 0)
                {
                    Console.WriteLine("Ошибка! Делить на ноль нельзя.");
                }
                else
                {
                   
                    switch (sign)
                    {
                        case '+':
                            result = one + two;
                            Console.WriteLine($"Результат: {one} + {two} = {result}");
                            break;
                        case '-':
                            result = one - two;
                            Console.WriteLine($"Результат: {one} - {two} = {result}");
                            break;
                        case '*':
                            result = one * two;
                            Console.WriteLine($"Результат: {one} * {two} = {result}");
                            break;
                        case '/':
                            result = one / two;
                            Console.WriteLine($"Результат: {one} / {two} = {result}");
                            break;
                    }
                }

                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }

        
        static bool IsExit(string input)
        {
            return input.ToLower() == "w";
        }
    }
}
