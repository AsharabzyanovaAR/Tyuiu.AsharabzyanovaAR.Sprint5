using System.IO;
using Tyuiu.AsharabzyanovaAR.Sprint5.Task2.V15.Lib;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task2.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\HONOR\AppData\Local\Temp\tmpvui2h0.tmp";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
