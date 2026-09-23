using Tyuiu.AbramenkoAS.Sprint1.Task0.V20.Lib;

namespace Tyuiu.AbramenkoAS.Sprint1.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(13, res);
        }
    }
}