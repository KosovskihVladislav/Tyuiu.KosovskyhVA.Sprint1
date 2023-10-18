﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskykhVA.Sprint1.Task7.V17.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task7                                                           *");
            Console.WriteLine("*Вариант #17                                                              *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение           ");
            Console.WriteLine("* и выводит результат на экран                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Место решения задания
            DataService service1 = new DataService();

            Console.Write("Введите x: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите y: ");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Результат выражения " + service1.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
