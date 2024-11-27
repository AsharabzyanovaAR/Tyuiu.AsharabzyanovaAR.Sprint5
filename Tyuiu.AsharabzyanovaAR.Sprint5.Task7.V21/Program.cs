using Tyuiu.AsharabzyanovaAR.Sprint5.Task7.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Ашарабзянова А. Р. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Удалить все знаки препинания из файла.                                  *");
        Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V21.txt.       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(@"D:\Рабочий Стол\DataSprint5\InPutDataFileTask7V21.txt");
        string pathSaveFile = Path.GetTempFileName();
        Console.WriteLine("Данные находятся в файле: " + path);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(dataService.LoadDataAndSave(path));

        Console.ReadKey();
    }
}