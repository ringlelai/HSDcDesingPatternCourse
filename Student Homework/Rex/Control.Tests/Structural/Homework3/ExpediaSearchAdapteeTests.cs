using hsdc.dpt.Control.Structural.Homework3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Control.Tests.Structural.Homework3
{
    [TestClass]
    public class ExpediaSearchAdapteeTests
    {
        [TestMethod]
        public void ExpediaSearchAdaptee_Get_AreEqual_51_Test()
        {
            ExpediaSearchAdaptee traget = new ExpediaSearchAdaptee();

            var actual = traget.Get();

            Assert.IsNotNull(actual);

            const int expected = 51;

            Assert.AreEqual(expected, actual.Count);
        }
    }
}