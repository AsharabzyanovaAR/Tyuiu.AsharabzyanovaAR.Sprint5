using Tyuiu.AsharabzyanovaAR.Sprint5.Task5.V6.Lib;
using System.IO;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\Рабочий Стол\DataSprint5\InPutDataFileTask5V6.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
