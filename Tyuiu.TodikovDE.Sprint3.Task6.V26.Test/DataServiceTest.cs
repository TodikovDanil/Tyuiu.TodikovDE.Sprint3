using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint3.Task6.V26.Lib;
namespace Tyuiu.TodikovDE.Sprint3.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 0;
            int stopValue = 1;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 120;
            Assert.AreEqual(wait, res);
        }
    }
}