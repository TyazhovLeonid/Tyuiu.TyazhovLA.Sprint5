using Tyuiu.TyazhovLA.Sprint5.Task7.V7.Lib;
namespace Tyuiu.TyazhovLA.Sprint5.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Тяжов Л. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Тяжов Леонид Александрович | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти количество четырехзначных чисел в заданной строке.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Путь к исходному файлу: C:\\DataSprint5\\Sprint5Task7\\InPutDataFileTask7V7.txt ");
            string path = "C:\\DataSprint5\\Sprint5Task7\\InPutDataFileTask7V7.txt";


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + ds.LoadDataAndSave(path) + " создан!");
        }
    }
    
}
