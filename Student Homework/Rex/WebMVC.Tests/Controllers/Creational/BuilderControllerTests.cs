using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using WebMVC.Controllers.Creational;
using WebMVC.ViewModels.Builder;

namespace WebMVC.Tests.Controllers.Creational
{
    [TestClass]
    public class BuilderControllerTests
    {
        [TestMethod]
        public void GET_NewOvertime_Return_ViewName_AreEqual_NewOvertime_Test()
        {
            BuilderController traget = new BuilderController();

            ViewResult actual = (ViewResult)traget.NewOvertime();

            const string expected = "NewOvertime";

            Assert.AreEqual(expected, actual.ViewName);
        }

        [TestMethod]
        public void PSOT_NewOvertime_ViewModel_AreEqual_Expected_Test()
        {
            NewOverTimeViewModel vm = new NewOverTimeViewModel
            {
                Applier = "Rex",
                ApplyDateTime = DateTime.Now.Date,
                OverTimeHour = 3,
            };

            BuilderController traget = new BuilderController();

            ViewResult actual = (ViewResult)traget.NewOvertime(vm);

            var expected = new
            {
                Applier = "Rex",
                ApplyDateTime = DateTime.Now.Date,
                OverTimeHour = 3,
            }.ToExpectedObject();

            expected.ShouldMatch(actual.Model);
        }
    }
}