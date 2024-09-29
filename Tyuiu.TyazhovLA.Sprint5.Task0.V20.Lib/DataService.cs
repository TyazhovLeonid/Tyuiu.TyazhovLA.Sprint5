using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.TyazhovLA.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            x = 2;
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            File.WriteAllText(path, Math.Round(2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2, 3)+ "");
            return path;

        }
    }
}
