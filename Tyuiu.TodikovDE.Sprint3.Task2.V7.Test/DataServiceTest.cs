using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint3.Task2.V7.Lib;
namespace Tyuiu.TodikovDE.Sprint3.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 123;
            Assert.AreEqual(wait, res);
        }
    }
    }
}