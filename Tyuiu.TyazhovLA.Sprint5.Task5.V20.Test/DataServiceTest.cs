using Tyuiu.TyazhovLA.Sprint5.Task5.V20.Lib;
namespace Tyuiu.TyazhovLA.Sprint5.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            DataService ds = new DataService();
            string path = "C:\\DataSprint5\\Sprint5Task5\\InPutDataFileTask5V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            Assert.IsTrue(fileexists);
        }
    }
}