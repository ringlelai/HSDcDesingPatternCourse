using ExpectedObjects;
using hsdc.dpt.Control.Creational.Builder;
using hsdc.dpt.Control.DTO.Creational.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Control.Tests.Creational.Builder
{
    [TestClass]
    public class OvertimeBuilderTests
    {
        [TestMethod]
        public void BuildMasterTest()
        {
            OvertimeBuilder builder = new OvertimeBuilder();
            EOfficeDirector<OverTime> director = new EOfficeDirector<OverTime>();
            OverTime actual = director.Construct(builder);

            var expected = new OverTime
            {
            }.ToExpectedObject();

            Assert.AreEqual(expected, actual);
        }
    }
}