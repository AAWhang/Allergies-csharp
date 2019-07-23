using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombination.Models;

namespace CoinCombination.Tests
{
    [TestClass]
    public class CoinCombinationTest
    {
        [TestMethod]
        public void AllergyCalc_AllericToCats_Cats()
        {
            changeCalc dollar = new changeCalc();
            Assert.AreEqual("Cats", dollar.AllergyCalc(128));
        }
        [TestMethod]
        public void AllergyCalc_AllergicMultiple_Cats()
        {
            changeCalc dollar = new changeCalc();
            Assert.AreEqual("Cats tomatoes strawberries peanuts eggs", dollar.AllergyCalc(155));
        }
    }
}