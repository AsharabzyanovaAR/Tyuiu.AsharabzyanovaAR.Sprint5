using Tyuiu.AsharabzyanovaAR.Sprint5.Task6.V13.Lib;
using System.IO;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"D:\Рабочий Стол\DataSprint5\InPutDataFileTask6V13.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void ValideCalc()
        {
            string path = @"D:\Рабочий Стол\DataSprint5\InPutDataFileTask6V13.txt";
            DataService ds = new DataService();
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
