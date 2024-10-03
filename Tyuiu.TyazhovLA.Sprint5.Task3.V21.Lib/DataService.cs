using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.Unicode;

namespace Tyuiu.TyazhovLA.Sprint5.Task3.V21.Lib
{
    public class DataService : ISprint5Task3V21
    {
        public string SaveToFileTextData(int x)
        {
            x = 3;
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });
            double y = Math.Round(((x*x+1)/Math.Sqrt(4*x*x-3)), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), encoding:System.Text.Encoding.UTF32))
                {
                writer.Write(BitConverter.GetBytes(y));
                }
            return path;
        }
    }
}
