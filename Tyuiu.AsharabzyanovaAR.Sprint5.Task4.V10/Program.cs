using Tyuiu.AsharabzyanovaAR.Sprint5.Task4.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Ашарабзянова А.Р. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле             *");
        Console.WriteLine("* x^3*1,2*x+2 Вычислить значение по формуле и вернуть                     *");
        Console.WriteLine("* полученный результат на консоль.                                        *");
        Console.WriteLine("***************************************************************************");
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"D:\Рабочий Стол\DataSprint5\InPutDataFileTask4V10.txt";
        Console.WriteLine("Данные находятся в файле: " + path);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = dataService.LoadFromDataFile(path);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}