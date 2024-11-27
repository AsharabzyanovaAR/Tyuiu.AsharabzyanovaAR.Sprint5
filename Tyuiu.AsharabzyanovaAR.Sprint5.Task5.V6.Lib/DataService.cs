using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');
                    foreach (string number in numbers)
                    {
                        double number_ = double.Parse(number, CultureInfo.InvariantCulture);
                        if (number_ != Convert.ToInt32(number_))
                        {
                            k += 1;
                            res = res + Math.Round(number_, 3);

                        }
                        
                    }
                }
            }
            return Math.Round(res/k,3);
        }
    }
}
