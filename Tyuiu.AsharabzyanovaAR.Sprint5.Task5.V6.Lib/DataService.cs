﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V5
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            int k = 0;
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line =reader.ReadLine() ) != null)
                {
                    k += 1;
                    res = res + Math.Round(Convert.ToDouble(line),3);
                }
            }
            return (res/k);
        }
    }
}