using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint3.Task3.V5.Lib;
namespace Tyuiu.TodikovDE.Sprint3.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "fifa al fall";
            char chr = 'a';
            char replacement = '*';
            string res = ds.ReplaceCharInString(value, chr, replacement);
            string wait = "fif* *l f*ll";
            Assert.AreEqual(wait, res);
        }
    }
}