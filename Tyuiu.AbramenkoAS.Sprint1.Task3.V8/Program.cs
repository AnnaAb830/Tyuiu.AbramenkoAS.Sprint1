using Tyuiu.AbramenkoAS.Sprint1.Task3.V8.Lib;

namespace Tyuiu.AbramenkoAS.Sprint1.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Абраменко А. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Оператор составного присваивания                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                             *");
            Console.WriteLine("* Выполнила: Абраменко Анна Сергеевна | ИБКСб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу,                *");
            Console.WriteLine("* процентная ставка и время хранения задаются пользователем.              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double startAmount;
            Console.WriteLine("Введите сумму вклада:");
            startAmount = Convert.ToDouble(Console.ReadLine());

            double percent;
            Console.WriteLine("Введите процентную ставку(годовых):");
            percent = Convert.ToDouble(Console.ReadLine());

            double timeDays;
            Console.WriteLine("Введите срок вклада(дней):");
            timeDays = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double dohod = ds.IncomeAmount(startAmount, percent, timeDays);

            Console.WriteLine("Доход: " + dohod + " руб.");
            Console.WriteLine("Сумма по окончании срока вклада: " + (startAmount + dohod) + " руб.");

            Console.ReadKey();
        }
    }
}
