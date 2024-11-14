using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TyazhovLA.Sprint5.Task7.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)
        {
            string pathOutput = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7.txt" });
            FileInfo fileInfo = new FileInfo(pathOutput);
            bool fileExists = fileInfo.Exists;
            if (fileExists) { File.Delete(pathOutput); }
            string stroka = File.ReadAllText(path);
            StringBuilder result = new StringBuilder();
            foreach (char c in stroka)
            {
                if (!char.IsUpper(c))
                {
                    result.Append(c);
                }
            }
                File.WriteAllText(pathOutput, result.ToString());
            return pathOutput;
        }
    }
}
