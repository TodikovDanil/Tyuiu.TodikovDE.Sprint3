using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint3.Task5.V27.Lib;
namespace Tyuiu.TodikovDE.Sprint3.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int starValue1 = 1;
            int stopValue1 = 3;
            int starValue2 = 1;
            int stopValue2= 10;
            int x = 2;
            double res = ds.GetSumSumSeries(x, starValue1, stopValue1, starValue2, stopValue2);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}