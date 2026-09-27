using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.AbramenkoAS.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            return Math.Round(startAmount * (percent / 100.0) * (timeDays / 365.0), 3);
        }
    }
}
