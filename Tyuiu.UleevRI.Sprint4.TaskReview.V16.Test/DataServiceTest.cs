using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint4.TaskReview.V16.Lib;

namespace Tyuiu.UleevRI.Sprint4.TaskReview.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 5;
            int columns = 3;
            int[,] num = new int[rows, columns];
            string str = "382976421897948";
            int res = ds.Calculate(rows, columns, str);
            int wait = 196608;
            Assert.AreEqual(wait, res);
        }
    }
}
