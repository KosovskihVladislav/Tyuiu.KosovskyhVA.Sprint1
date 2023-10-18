using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint1.Task3.V14.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(280,72, service1.ReverseNumber(872));
        }
    }
}
