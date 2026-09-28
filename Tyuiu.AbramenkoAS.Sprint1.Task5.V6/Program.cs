using Tyuiu.AbramenkoAS.Sprint1.Task5.V6.Lib;

namespace Tyuiu.AbramenkoAS.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнилa: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя номер дня в году *");
            Console.WriteLine("* и вычисляет, на какой день недели он приходится,                        *");
            Console.WriteLine("* если 1 января - понедельник.                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int k;
            Console.WriteLine("Введите номер дня в году(от 1 до 365):");
            k = Convert.ToInt32(Console.ReadLine());

            int n = ds.Calculate(k);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"День недели(1 - 7): {n}");
            Console.ReadKey();
        }
    }
}
