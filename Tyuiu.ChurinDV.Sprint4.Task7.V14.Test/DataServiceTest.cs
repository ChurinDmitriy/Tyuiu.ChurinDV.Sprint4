using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint4.Task7.V14.Lib;

namespace Tyuiu.ChurinDV.Sprint4.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int rows = 3;
            int colums = 4;
            int[,] mtrx = new int[rows, colums];
            string str = "458712659137";

            int res = ds.Calculate(rows, colums, str);
            int wait = 38;

            Assert.AreEqual(wait, res);
        }
    }
}
