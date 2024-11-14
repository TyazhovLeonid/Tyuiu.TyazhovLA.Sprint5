using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TyazhovLA.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(" ");
            double[] chisla= new double[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                chisla[i]= Convert.ToDouble(strings[i]);
            }
            int count = 0;
            double sum = 0;
            for (int i = 0;i < chisla.Length; i++)
            {
                if ((chisla[i] >= -10) && (chisla[i]<=10))
                {
                    sum += chisla[i];
                    count++;
                }
            }
            double res = Math.Round(sum / count, 3);
            return res;
        }
    }
}
