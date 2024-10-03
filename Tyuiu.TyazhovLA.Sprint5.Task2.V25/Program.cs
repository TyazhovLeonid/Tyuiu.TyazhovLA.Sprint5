
using Tyuiu.TyazhovLA.Sprint5.Task2.V25.Lib;
namespace Tyuiu.TyazhovLA.Sprint5.Task2.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Тяжов Л. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File                                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Тяжов Леонид Александрович | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = { { 4, 8, 5 }, { 1, 4, 2 }, { 4, 9, 9 } };
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + ds.SaveToFileTextData(matrix));
            Console.WriteLine("Создан!");
            String line;

            string path = "C:\\Users\\myach\\AppData\\Local\\Temp\\OutPutFileTask2.csv";
            StreamReader sr = new StreamReader(path);

            line = sr.ReadLine();
            int x = -5;
            while (line != null)
            {

                Console.WriteLine(line); 
                line = sr.ReadLine();
            }

            sr.Close();
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
