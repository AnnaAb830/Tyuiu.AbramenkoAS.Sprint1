using Tyuiu.AbramenkoAS.Sprint1.Task6.V13.Lib;

namespace Tyuiu.AbramenkoAS.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string text = "абв";
            var res = ds.CheckWordsAlphabet(text);
            Assert.IsTrue(res);
        }
    }
}
