using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TkachukSS.Sprint5.Task3.V5.Lib;
namespace Tyuiu.TkachukSS.Sprint5.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Hardwired\source\repos\Tyuiu.TkachukSS.Sprint5\Tyuiu.TkachukSS.Sprint5.Task3.V5\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
