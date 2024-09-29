using Tyuiu.TyazhovLA.Sprint5.Task0.V20.Lib;
using System.IO;
namespace Tyuiu.TyazhovLA.Sprint5.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "C:\\Users\\myach\\source\\repos\\Tyuiu.TyazhovLA.Sprint5\\Tyuiu.TyazhovLA.Sprint5.Task0.V20\\bin\\Debug\\net8.0\\OutPutFileTask0.txt";
            var res = ds.SaveToFileTextData(0);
            Assert.AreEqual(path, res);
        }
    }
}