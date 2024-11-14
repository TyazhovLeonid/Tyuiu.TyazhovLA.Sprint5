using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TyazhovLA.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
           string stroka = File.ReadAllText(path);
           string[] spl = stroka.Split(" ");
            int count = 0;
            for (int i = 0; i < spl.Length; i++)
            {
                if (int.TryParse(spl[i].Trim(), out int value) && spl[i].Length == 4) count++;
            }
            return count;
        }
    }
}
