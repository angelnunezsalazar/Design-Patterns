using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Starbuzz.Tests
{
    [TestClass]
    public class BeveragesTests
    {
        private const double DELTA = 0.00001;

        [TestMethod]
        public void Espresso()
        {
            Espresso beverage = new Espresso();
            Assert.AreEqual(1.99, beverage.Cost(), DELTA);
        }

        [TestMethod]
        public void HouseBlendWithSoyWithMochaWithWhip()
        {
            HouseBlend beverage = new HouseBlend();
            beverage.HasSoy = true;
            beverage.HasMocha = true;
            beverage.HasWhip = true;

            Assert.AreEqual(1.34, beverage.Cost(), DELTA);
        }

        [TestMethod]
        public void DarkRoastWithMochaWithWhipWithMilk()
        {
            DarkRoast beverage = new DarkRoast();
            beverage.HasMocha = true;
            beverage.HasWhip = true;
            beverage.HasMilk = true;
            Assert.AreEqual(1.39, beverage.Cost(), DELTA);
        }
    }
}
