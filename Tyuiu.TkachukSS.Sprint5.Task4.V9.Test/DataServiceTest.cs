using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint5.Task4.V7.Lib;
using System.IO;
namespace Tyuiu.TkachukSS.Sprint5.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V9.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
