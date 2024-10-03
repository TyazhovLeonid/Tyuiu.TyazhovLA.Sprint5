using Tyuiu.TyazhovLA.Sprint5.Task3.V21.Lib;
namespace Tyuiu.TyazhovLA.Sprint5.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {   DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Тяжов Л. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Тяжов Леонид Александрович | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 3, результат сохранить   *");
            Console.WriteLine("* в текстовый файл OutPutFileTask3.bin и вывести на консоль. Округлить до *");
            Console.WriteLine("* трёх знаков после запятой.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл: " + ds.SaveToFileTextData(x));
            Console.WriteLine("Создан!");
            String line;

            string path = "C:\\Users\\myach\\AppData\\Local\\Temp\\OutPutFileTask3.bin";
            StreamReader sr = new StreamReader(path);

            line = sr.ReadLine();
            
            while (line != null )
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
