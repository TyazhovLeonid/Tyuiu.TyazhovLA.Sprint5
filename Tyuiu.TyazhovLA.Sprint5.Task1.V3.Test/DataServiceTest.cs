using Tyuiu.TyazhovLA.Sprint5.Task1.V3.Lib;
namespace Tyuiu.TyazhovLA.Sprint5.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "C:\\Users\\myach\\AppData\\Local\\Temp\\OutPutFileTask1.txt";
            var res = ds.SaveToFileTextData(-5,5);
            Assert.AreEqual(path, res);
        }
    }
}