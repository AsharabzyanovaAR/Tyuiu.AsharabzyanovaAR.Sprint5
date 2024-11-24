using System.IO;
using Tyuiu.AsharabzyanovaAR.Sprint5.Task0.V11.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"D:\Рабочий Стол\t\Tyuiu.AsharabzyanovaAR.Sprint5\Tyuiu.AsharabzyanovaAR.Sprint5.Task0.V11\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
