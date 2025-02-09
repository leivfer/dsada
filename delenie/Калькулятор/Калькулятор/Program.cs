﻿using System;

namespace DivisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в приложение для деления!");
            Console.WriteLine("Введите 'exit' для выхода из программы.");

            while (true)
            {
                Console.WriteLine("\nВведите первое число (или 'exit' для выхода):");
                string input1 = Console.ReadLine();

                if (input1.ToLower() == "exit")
                {
                    break; // Выход из программы
                }

                Console.WriteLine("Введите второе число (или 'exit' для выхода):");
                string input2 = Console.ReadLine();

                if (input2.ToLower() == "exit")
                {
                    break; // Выход из программы
                }

                if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
                {
                    if (number2 != 0)
                    {
                        double result = number1 / number2;
                        Console.WriteLine($"Результат деления: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль невозможно.");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите валидные числа.");
                }
            }

            Console.WriteLine("Спасибо за использование приложения! До свидания.");
        }
    }
}
