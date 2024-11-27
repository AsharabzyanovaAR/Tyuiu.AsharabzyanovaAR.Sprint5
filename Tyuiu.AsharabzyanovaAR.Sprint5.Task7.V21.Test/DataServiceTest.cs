using Tyuiu.AsharabzyanovaAR.Sprint5.Task7.V21.Lib;
using System.IO;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"D:\Рабочий Стол\DataSprint5\InPutDataFileTask7V21.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
