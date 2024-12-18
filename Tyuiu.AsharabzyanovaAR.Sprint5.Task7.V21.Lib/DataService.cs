﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task7.V21.Lib
{
    public class DataService : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != '.' && line[i] != '-' && line[i] != ',' && line[i] != '!' && line[i] != '?')
                        {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine+Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
