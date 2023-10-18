using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskykhVA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KosovskykhVA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    { 
        public void CheckCalc()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(2, service1.AngleToHoursMinutes(60));
        }

    }
}
