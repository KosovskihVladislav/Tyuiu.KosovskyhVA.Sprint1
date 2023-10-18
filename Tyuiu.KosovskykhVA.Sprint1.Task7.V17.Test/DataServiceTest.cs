using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint1.Task7.V17.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(6.772, service1.Calculate(30, 1));
        }
    }
}
