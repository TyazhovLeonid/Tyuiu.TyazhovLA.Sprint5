using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
 
namespace Tyuiu.TyazhovLA.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.csv" });
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) { File.Delete(path); }
            int rows = 3; int cols = 3;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0) matrix[i, j] = 0;
                }
            }
            string s = "";
            for (int i = 0;i < cols; i++)
            {
                for (int j = 0;j < rows; j++)
                {
                    if (j != cols-1) s = s + matrix[i, j] + ";";
                    else s = s+ matrix[i, j];
                }
                if (i != rows-1) File.AppendAllText(path,s + Environment.NewLine);
                else File.AppendAllText(path,s);
                s = "";
            }
            
            return path;
        }
    }
}
