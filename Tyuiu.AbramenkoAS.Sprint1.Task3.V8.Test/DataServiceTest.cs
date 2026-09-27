using Tyuiu.AbramenkoAS.Sprint1.Task3.V8.Lib;

namespace Tyuiu.AbramenkoAS.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double startAmount = 2500;
            double persent = 20;
            double timeDays = 30;
            var res = ds.IncomeAmount(startAmount, persent, timeDays);
            Assert.AreEqual(41.096, res);
        }
    }
}
