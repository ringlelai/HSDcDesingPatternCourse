using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebMVC.Controllers.Creational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using hsdc.dpt.Control.Creational.Builder;
using hsdc.dpt.Control.DTO.Creational.Builder;
using ExpectedObjects;

namespace WebMVC.Controllers.Creational.Tests
{
    [TestClass()]
    public class BuilderControllerTests
    {
        [TestMethod()]
        public void testNewLeave()
        {
            LeaveBuilder builder = new LeaveBuilder();
            EOfficeDirector<Leave> director = new EOfficeDirector<Leave>();

            Leave actual = director.Construct(builder);          
            Leave expected = getExpectedLeave();

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        private Leave getExpectedLeave()
        {
            Leave result = new Leave();
            
            return result;
        }

        [TestMethod()]
        public void testNewOverTime()
        {
            OverTimeBuilder builder = new OverTimeBuilder();
            EOfficeDirector<OverTime> director = new EOfficeDirector<OverTime>();
     
            OverTime actual = director.Construct(builder);
            OverTime expected = new OverTime();

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void testSaveOverTime()
        {
            SaveOverTimeControl uco = new SaveOverTimeControl();

            OverTime actual = new OverTime();
            actual = uco.Save(actual);

            OverTime expected = new OverTime();
            expected.OverTimeId = "0001";

            expected.ToExpectedObject().ShouldEqual(actual);

        }



    }
}