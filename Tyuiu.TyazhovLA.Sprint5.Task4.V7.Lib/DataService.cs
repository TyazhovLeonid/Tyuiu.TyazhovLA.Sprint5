using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TyazhovLA.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            var strX = File.ReadAllText(path);
            double x = double.Parse(strX);
            double y = Math.Round(1 / Math.Cos(x) + Math.Pow(x, 3), 3);
            return y;
        }
    }
}
