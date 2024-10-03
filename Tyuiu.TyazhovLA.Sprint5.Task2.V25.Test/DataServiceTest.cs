using Tyuiu.TyazhovLA.Sprint5.Task2.V25.Lib;
namespace Tyuiu.TyazhovLA.Sprint5.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 4, 8, 5 }, { 1, 4, 2 }, { 4, 9, 9 } };
            string path = "C:\\Users\\myach\\AppData\\Local\\Temp\\OutPutFileTask2.csv";
            var res = ds.SaveToFileTextData(matrix);
            Assert.AreEqual(path, res);
        }
    }
}