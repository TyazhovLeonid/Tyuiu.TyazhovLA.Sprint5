using Tyuiu.TyazhovLA.Sprint5.Task3.V21.Lib;
namespace Tyuiu.TyazhovLA.Sprint5.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "C:\\Users\\myach\\AppData\\Local\\Temp\\OutPutFileTask3.bin";
            var res = ds.SaveToFileTextData(3);
            Assert.AreEqual(path, res);
        }
    }
}