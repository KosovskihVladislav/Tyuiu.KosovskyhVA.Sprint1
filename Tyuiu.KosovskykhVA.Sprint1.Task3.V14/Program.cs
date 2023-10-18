using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskykhVA.Sprint1.Task3.V14.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task3                                                           *");
            Console.WriteLine("*Вариант #14                                                              *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая переписывает число в обратном порядке       *");
            Console.WriteLine("* и выводит результат на экран.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Место решения задания
            DataService service1 = new DataService();

            Console.Write("Введите трехзначное число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string xs = x.ToString();
            int xsx = xs.Length;
            if (xsx == 3)
            {
                Console.WriteLine("В обратном порядке " + service1.ReverseNumber(x));
            }
            else
            {
                Console.WriteLine("Это не трехзначное число");
            }
            Console.ReadKey();
        }
    }
}
