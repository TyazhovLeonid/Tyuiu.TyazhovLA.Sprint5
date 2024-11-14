using Tyuiu.TyazhovLA.Sprint5.Task6.V28.Lib;
namespace Tyuiu.TyazhovLA.Sprint5.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            DataService ds = new DataService();
            string path = "C:\\DataSprint5\\Sprint5Task6\\InPutDataFileTask6V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            Assert.IsTrue(fileexists);
        }
    }
}