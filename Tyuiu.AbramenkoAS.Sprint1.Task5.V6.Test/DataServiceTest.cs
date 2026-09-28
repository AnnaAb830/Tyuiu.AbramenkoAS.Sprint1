using Tyuiu.AbramenkoAS.Sprint1.Task5.V6.Lib;

namespace Tyuiu.AbramenkoAS.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 10;
            var res = ds.Calculate(k);
            Assert.AreEqual(3, res);
        }
    }
}
