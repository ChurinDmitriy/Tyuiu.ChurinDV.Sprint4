using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint4.Task6.V16.Lib;

namespace Tyuiu.ChurinDV.Sprint4.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var week = new string[] { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            int res = ds.Calculate(week);
            int wait = 0;
            Assert.AreEqual(wait, res);

        }
    }
}
