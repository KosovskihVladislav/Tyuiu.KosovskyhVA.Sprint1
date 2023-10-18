using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint1.Task4.V2.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(0.25, service1.Calculate(8, 4));
        }
    }
}
