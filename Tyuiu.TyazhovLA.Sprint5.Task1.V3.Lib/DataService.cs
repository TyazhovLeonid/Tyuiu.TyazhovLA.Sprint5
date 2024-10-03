﻿
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.TyazhovLA.Sprint5.Task1.V3.Lib
{
    public class DataService : ISprint5Task1V3
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) {File.Delete(path); }
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = Math.Round((Math.Cos(2*x) + ((Math.Sin(x))/(x+2.5))+2*x), 2);
                string strY = Convert.ToString(y);
                if (x!=stopValue) {File.AppendAllText(path, strY+ Environment.NewLine);  }
                else { File.AppendAllText(path, strY);  }
                
                
            }
            return path;
        }
    }
}
