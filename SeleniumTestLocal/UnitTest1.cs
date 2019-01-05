using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumTestForEA;
using TestProject.SDK;
using TestProject.SDK.Common.Enums;

namespace SeleniumTestLocal
{
    [TestClass]
    public class UnitTest1
    {

        private static string DevToken = "U--LKi5tve35kNidu4uRp5IzAWrhL7PNVp3jEn4Y55U1";
        private static AutomatedBrowserType BrowserType = AutomatedBrowserType.Chrome;


        [TestMethod]
        public void TestMethod1()
        {
            using (Runner runner = RunnerFactory.Instance.CreateWeb(DevToken, BrowserType))
                runner.Run(new SeleniumTest());

        }
    }
}
