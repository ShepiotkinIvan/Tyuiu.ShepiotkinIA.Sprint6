﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint6.Task0.V24.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 1024;
            Assert.AreEqual(wait, res);
        }
    }
}
