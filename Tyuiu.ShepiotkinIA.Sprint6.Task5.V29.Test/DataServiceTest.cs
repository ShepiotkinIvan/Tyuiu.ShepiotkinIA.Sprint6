using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint6.Task5.V29.Lib;
using System.IO;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\FedorShluhin\source\repos\Tyuiu.ShepiotkinIA.Sprint6\Tyuiu.ShepiotkinIA.Sprint6.Task5.V29\bin\Debug\InPutFileTask5V29.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
