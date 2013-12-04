using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Duck.Tests
{
    [TestClass]
    public class RubberDuckTests
    {
        private Duck duck;

        [TestInitialize]
        public void Setup()
        {
            duck = new RubberDuck();
        }

        [TestMethod]
        public void CantFly()
        {
            duck.FlyBehavoir = new FlyNoWay();
            Assert.AreEqual(DuckMessages.CantFly, duck.Fly());
        }

        [TestMethod]
        public void Squeak()
        {
            duck.QuackBehavior=new Squeak();
            Assert.AreEqual(DuckMessages.Squeak, duck.Quack());
        }


        [TestMethod]
        public void Display()
        {
            Assert.AreEqual(DuckMessages.RubberDisplay, duck.Display());
        }
    }
}
