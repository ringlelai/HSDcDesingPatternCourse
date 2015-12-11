using hsdc.dpt.Control.Structural.Homework3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Control.Tests.Structural.Homework3
{
    [TestClass]
    public class RestaurantInquireUcoTests
    {
        [TestMethod]
        public void RestaurantInquireUco_GetPresetList_AreEqual_53_Test()
        {
            RestaurantInquireUco traget = new RestaurantInquireUco(true);

            var actual = traget.GetPresetList().Count;

            const int expected = 63;

            Assert.AreEqual(expected, actual);
        }
    }
}