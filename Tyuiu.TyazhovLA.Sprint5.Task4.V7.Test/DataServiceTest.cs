using Tyuiu.TyazhovLA.Sprint5.Task4.V7.Lib;
namespace Tyuiu.TyazhovLA.Sprint5.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            DataService ds = new DataService();
            string path = "C:\\DataSprint5\\Sprint5Task4\\InPutDataFileTask4V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            Assert.IsTrue(fileexists);
        }
    }
}