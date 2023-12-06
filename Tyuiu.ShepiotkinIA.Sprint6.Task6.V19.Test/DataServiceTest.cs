using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShepiotkinIA.Sprint6.Task6.V19.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFail()
        {
            DataService ds = new DataService();
            string path = @"C:\Task6\InPutFileTask6V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
