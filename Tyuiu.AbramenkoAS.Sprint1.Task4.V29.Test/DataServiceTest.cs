using Tyuiu.AbramenkoAS.Sprint1.Task4.V29.Lib;

namespace Tyuiu.AbramenkoAS.Sprint1.Task4.V29.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = -5;
            double y = 1;
            var res = ds.Calculate(x, y);

            Assert.AreEqual(-0.2, res);
        }
    }
}
