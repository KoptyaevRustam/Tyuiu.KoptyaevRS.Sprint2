using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint2.Task6.V10.Lib;

namespace Tyuiu.KoptyaevRS.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("31.12.1999", ds.FindDateOfPreviousDay(2000, 1, 1));
            Assert.AreEqual("28.11.2000", ds.FindDateOfPreviousDay(2000, 11, 29));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(2000, 11, -5);
            });
        }
    }
}
