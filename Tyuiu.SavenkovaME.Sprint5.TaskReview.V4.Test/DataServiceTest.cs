using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint5.TaskReview.V4.Lib;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadDataAndSave()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V4.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}
