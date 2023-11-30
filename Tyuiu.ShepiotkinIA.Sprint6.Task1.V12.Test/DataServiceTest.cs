using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint6.Task1.V12.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task1.V12.Test
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
            int len = stop - start + 1;
            double[] wait = new double[len];
            wait[0] = -8.86;
            wait[1] = -7.19;
            wait[2] = -6.14;
            wait[3] = -4.76;
            wait[4] = -2.33;
            wait[5] = 1.00;
            wait[6] = 4.38;
            wait[7] = 0.00;
            wait[8] = 6.13;
            wait[9] = 7.07;
            wait[10] = 8.61;
            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
