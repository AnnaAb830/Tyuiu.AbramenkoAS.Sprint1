using Tyuiu.AbramenkoAS.Sprint1.Task7.V14.Lib;

namespace Tyuiu.AbramenkoAS.Sprint1.Task7.V14
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Абраменко А. С. | ИБКСб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("*             5x^2                          ");
            Console.WriteLine("z = 2^(-x) + --——— - cos(x^2) + sin(2xy)");
            Console.WriteLine("              3x^3");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Ошибка: X не может быть равен 0.");
            }
            else
            {
                Console.WriteLine("Введите Y:");
                y = Convert.ToDouble(Console.ReadLine());


                double z = ds.Calculate(x, y);
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("*             5x^2                          ");
                Console.WriteLine($"z = 2^(-x) + --——— - cos(x^2) + sin(2xy) = {z}");
                Console.WriteLine("              3x^3");
                Console.ReadKey();
            }
        }
    }
}
