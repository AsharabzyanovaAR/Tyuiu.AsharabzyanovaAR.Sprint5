using Tyuiu.AsharabzyanovaAR.Sprint5.Task5.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Ашарабзянова А.Р. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл  в котором есть набор значений. Найти среднее значение.        *");
        Console.WriteLine("* Полученный результат вывести на консоль.                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        DataService dataService = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"D:\Рабочий Стол\DataSprint5\InPutDataFileTask5V6.txt";
        Console.WriteLine("Данные находятся в файле: " + path);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = dataService.LoadFromDataFile(path);

        Console.WriteLine("Среднее значение: " + res);
        Console.ReadKey();
    }
}