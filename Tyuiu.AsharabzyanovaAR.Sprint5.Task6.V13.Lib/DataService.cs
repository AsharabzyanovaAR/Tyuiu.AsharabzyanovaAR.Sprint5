using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Net.Mail;
namespace Tyuiu.AsharabzyanovaAR.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (((line[i] == 'с') && (line[i + 1] == 'с'))||((line[i] == 'С') && (line[i + 1] == 'с')))
                        {
                            count+=1;
                        }
                    }
                }
            }
            return count;
        }
    }
}
