using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint1.Task1.V9.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(2, service1.Calculate(5, 2));
        }
    }
}
