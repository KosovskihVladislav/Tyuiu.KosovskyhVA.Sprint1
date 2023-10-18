using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint1.Task2.V14.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(278, service1.ConvertKelvinToCelsius(5));
        }
    }
}
