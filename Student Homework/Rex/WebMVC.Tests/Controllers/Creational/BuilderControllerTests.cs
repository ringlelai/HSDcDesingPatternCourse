using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WebMVC.Controllers.Creational;

namespace WebMVC.Tests.Controllers.Creational
{
    [TestClass]
    public class BuilderControllerTests
    {
        [TestMethod()]
        public void NewOvertimeTest()
        {
            BuilderController traget = new BuilderController();

            ViewResult actual = (ViewResult)traget.NewOvertime();

            const string expected = "NewOvertime";

            Assert.AreEqual(expected, actual.ViewName);
        }
    }
}