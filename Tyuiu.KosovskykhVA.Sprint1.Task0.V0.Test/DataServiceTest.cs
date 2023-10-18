using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint1.Task0.V6.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(15, service1.Calculate());
        }
    }
}
