using Tyuiu.FilippovaVD.Sprint3.Task3.V25.Lib;

namespace Tyuiu.FilippovaVD.Sprint3.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв 'и', находящихся на   *");
            Console.WriteLine("* соседних позициях в строке.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "kjhgfии gujut dtuu";
            char item = 'и';

            Console.WriteLine($"Строка: {value}");
            Console.WriteLine($"Искомый символ: {item}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetMinCharCount(value, item);
            Console.WriteLine($"Количество подряд идущих символов '{item}' = {result}");

            Console.ReadLine();
        }
    }
}
