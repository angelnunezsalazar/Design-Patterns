using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Starbuzz.Tests
{
    [TestClass]
    public class BeveragesTests
    {
        private const double DELTA = 0.00001;

        [TestMethod]
        public void Expresso()
        {
            Beverage beverage = new Expresso();
            Assert.AreEqual(1.99, beverage.Cost(),DELTA);
        }

        [TestMethod]
        public void HouseBlendWithSoyWithMochaWithWhip()
        {
            Beverage beverage = new HouseBlend();
            beverage = new Soy(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);

            Assert.AreEqual(1.34, beverage.Cost(),DELTA);
        }

        [TestMethod]
        public void DarkRoastWithMochaWithWhipWithMilk()
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            beverage = new Milk(beverage);
            Assert.AreEqual(1.39, beverage.Cost(),DELTA);
        }
    }
}
