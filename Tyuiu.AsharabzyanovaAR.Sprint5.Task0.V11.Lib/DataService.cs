using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task0.V11.Lib
{
    public class DataService : ISprint5Task0V11

    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double z = (4 - Math.Pow(x, 3)) / (Math.Pow(x, 2));
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
