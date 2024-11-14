
namespace Tyuiu.TyazhovLA.Sprint5.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckInputFileExists()
        {  
            
            string path = "C:\\DataSprint5\\Sprint5Task7\\InPutDataFileTask7V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            Assert.IsTrue(fileexists);
            
        }
        
    }
}