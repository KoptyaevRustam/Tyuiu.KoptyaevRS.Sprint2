using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint2.Task5.V13.Lib;

namespace Tyuiu.KoptyaevRS.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void valid1()
        {
            DataService ds = new DataService();

            double wait = 16.04;
            Assert.AreEqual(wait, ds.FindDateOfNextDay(2000, 4, 15));
        }
    }
}
