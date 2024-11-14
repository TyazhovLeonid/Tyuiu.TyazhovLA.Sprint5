using Tyuiu.TyazhovLA.Sprint5.Task5.V20.Lib;
namespace Tyuiu.TyazhovLA.Sprint5.Task5.V20
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Тяжов Леонид Александрович | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти среднее значение всех целых чисел в файле, которые находятся      *");
            Console.WriteLine("* в промежутке от -10 до 10.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Путь к файлу: C:\\DataSprint5\\Sprint5Task5\\InPutDataFileTask5V20.txt ");
            string path = "C:\\DataSprint5\\Sprint5Task5\\InPutDataFileTask5V20.txt";


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Ответ: " + ds.LoadFromDataFile(path));
        }
    }
}
