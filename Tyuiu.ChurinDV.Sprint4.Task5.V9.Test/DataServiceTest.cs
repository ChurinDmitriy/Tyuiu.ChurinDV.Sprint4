using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint4.Task5.V9.Lib;

namespace Tyuiu.ChurinDV.Sprint4.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { { -2, 3, 2, 1, 0 }, { 4, 3, -3, 2, -4 }, { 2, 3, 3, 3, -4 }, { 2, -3, -3, -2, 2 }, { 4, -1, 4, 3, 0 } };

            int wait = 17;
            int res = ds.Calculate(mas);

            Assert.AreEqual(wait, res);

        }
    }
}
