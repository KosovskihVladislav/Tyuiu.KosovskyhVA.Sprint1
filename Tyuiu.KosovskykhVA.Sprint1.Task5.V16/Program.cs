using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskykhVA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task5                                                           *");
            Console.WriteLine("*Вариант #7                                                               *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая выводит полное количество часов             *");
            Console.WriteLine("* прошедших от начала суток до того момента.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Место решения задания
            DataService service1 = new DataService();

            Console.Write("Введите от 0 до 360 градусов: ");
            double f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (0 <= f && f <= 360)
            {
                Console.WriteLine("Прошло " + service1.AngleToHoursMinutes(f) + " часов.");
            }
            else
            {
                Console.WriteLine("Введите от 0 до 360 градусов");
            }
            Console.ReadKey();
        }
    }
}
