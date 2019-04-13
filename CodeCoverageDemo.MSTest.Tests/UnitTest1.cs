using CodeCoverageDemo.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeCoverageDemo.MSTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var homeController = new HomeController();
            var viewResult = homeController.Index() as ViewResult;
            var model = viewResult.Model;
            var returnVal = viewResult.Model == null ? -1 : (int)model;

            Assert.AreEqual(5, returnVal);
        }
    }
}
