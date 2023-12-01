using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint6.Task2.V3.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = ds.GetMassFunction(start, stop).Length;
            double[] wait = new double[len];
            wait[0] = -12.18;
            wait[1] = 16.03;
            wait[2] = 18.87;
            wait[3] = 4.96;
            wait[4] = -9.99;
            wait[5] = -2.00;
            wait[6] = 2.16;
            wait[7] = -7.54;
            wait[8] = -22.76;
            wait[9] = -20.45;
            wait[10] = 7.77;
            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
