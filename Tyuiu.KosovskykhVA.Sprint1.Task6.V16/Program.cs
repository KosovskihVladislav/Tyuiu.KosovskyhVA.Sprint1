using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskykhVA.Sprint1.Task6.V16.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task6.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task6                                                           *");
            Console.WriteLine("*Вариант #16                                                              *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая проверяет,                                  *");
            Console.WriteLine("* что в строке есть восклицание (!) и вопрос (?).                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Место решения задания
            DataService service1 = new DataService();

            Console.Write("Введите предложение: ");
            string f = Console.ReadLine();
            Console.WriteLine();
            if (service1.CheckSpecSymbols(f))
            {
                Console.WriteLine("В вашем предложении есть символы ((!?))");
            }
            else
            {
                Console.WriteLine("В вашем предложении нет символов ((!?))");
            }
            Console.ReadKey();
        }
    }
}