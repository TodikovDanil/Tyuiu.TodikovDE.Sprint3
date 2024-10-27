using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint3.Task7.V2.Lib;
namespace Tyuiu.TodikovDE.Sprint3.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 1;
            valueWaitArray[1] = 2;
            valueWaitArray[2] = 3;
            valueWaitArray[3] = 4;
            valueWaitArray[4] = 5;
            valueWaitArray[5] = 6;
            valueWaitArray[6] = 7;
            valueWaitArray[7] = 8;
            valueWaitArray[8] = 9;
            valueWaitArray[9] = 10;
            valueWaitArray[10] = 11;

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}