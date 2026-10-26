using Tyuiu.FilippovaVD.Sprint3.Task7.V23.Lib;

namespace Tyuiu.FilippovaVD.Sprint3.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* F(x) на диапазоне [-5; 5] с шагом 1. Округлить до 2 знаков.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Диапазон: [{startValue}; {stopValue}]");
            Console.WriteLine("Шаг: 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+-------+--------+");
            Console.WriteLine("|   X   |  F(x)  |");
            Console.WriteLine("+-------+--------+");

            int x = startValue;
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"| {x,5} | {result[i],6} |");
                x++;
            }
            Console.WriteLine("+-------+--------+");

            Console.ReadLine();
        }
    }
}