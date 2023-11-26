using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint5.Task2.V14.Lib;
using System.IO;
namespace Tyuiu.TkachukSS.Sprint5.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Hardwired\source\repos\Tyuiu.TkachukSS.Sprint5\Tyuiu.TkachukSS.Sprint5.Task2.V14\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
