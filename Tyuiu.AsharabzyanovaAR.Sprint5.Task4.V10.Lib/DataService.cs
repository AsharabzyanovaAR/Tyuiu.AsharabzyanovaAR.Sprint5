using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double res = Math.Round(Math.Pow(Convert.ToDouble(strx), 3) * 1.2 * Convert.ToDouble(strx) + 2, 3);
            return res;
        }
    }
}
