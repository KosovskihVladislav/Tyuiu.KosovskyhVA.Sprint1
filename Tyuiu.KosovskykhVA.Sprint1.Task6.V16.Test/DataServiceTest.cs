using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint1.Task6.V16.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(true, service1.CheckSpecSymbols("LOL!?"));
        }
    }
}
