using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAjax.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController hc = new HomeController();

            System.Diagnostics.Debug.WriteLine("UnitTest: Получен результат запроса - " + hc.GetTestModel(8).Data);
            Assert.IsNotNull(hc.GetTestModel(8));
        }
    }
}
