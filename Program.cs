using laba_6;
using System;

namespace laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите категорию:");
                Console.WriteLine("1. Основные задания (if-else, 1–10)");
                Console.WriteLine("2. Задания с тернарным оператором (1–4)");
                Console.WriteLine("0. Выход");

                Console.Write("Введите номер категории: ");
                int category;
                while (!int.TryParse(Console.ReadLine(), out category))
                    Console.Write("Ошибка. Введите число: ");

                Console.Clear();

                if (category == 0) return;

                switch (category)
                {
                    case 1:
                        Console.WriteLine("Выберите задание (1–10): ");
                        int task1 = int.Parse(Console.ReadLine());
                        switch (task1)
                        {
                            case 1: IfTasks.Task1(); break;
                            case 2: IfTasks.Task2(); break;
                            case 3: IfTasks.Task3(); break;
                            case 4: IfTasks.Task4(); break;
                            case 5: IfTasks.Task5(); break;
                            case 6: IfTasks.Task6(); break;
                            case 7: IfTasks.Task7(); break;
                            case 8: IfTasks.Task8(); break;
                            case 9: IfTasks.Task9(); break;
                            case 10: IfTasks.Task10(); break;
                            default: Console.WriteLine("Нет такого задания."); break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Выберите задание (1–4): ");
                        int task2 = int.Parse(Console.ReadLine());
                        switch (task2)
                        {
                            case 1: AddTasks.Task1(); break;
                            case 2: AddTasks.Task2(); break;
                            case 3: AddTasks.Task3(); break;
                            case 4: AddTasks.Task4(); break;
                            default: Console.WriteLine("Нет такого задания."); break;
                        }
                        break;

                    default:
                        Console.WriteLine("Нет такой категории.");
                        break;
                }

                Console.WriteLine("\nНажмите Enter, чтобы продолжить...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
