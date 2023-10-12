using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint2.Task4.V22.Lib;

namespace Tyuiu.KoptyaevRS.Sprint2.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 11;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 11;
            double res = ds.Calculate(x, y);
            double wait = 0.211;
            Assert.AreEqual(wait, res);
        }
    }
}
