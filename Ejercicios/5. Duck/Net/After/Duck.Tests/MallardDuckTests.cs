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
    public class MallardDuckTests
    {
        private Duck duck;

        [TestInitialize]
        public void Setup()
        {
            duck = new MallardDuck();
        }

        [TestMethod]
        public void Fly()
        {
            duck.FlyBehavoir=new FlyWithWings();
            Assert.AreEqual(DuckMessages.Fly, duck.Fly());
        }

        [TestMethod]
        public void Quack()
        {
            duck.QuackBehavior=new Quack();
            Assert.AreEqual(DuckMessages.Quack, duck.Quack());
        }


        [TestMethod]
        public void Display()
        {
            Assert.AreEqual(DuckMessages.MallardDisplay, duck.Display());
        }

        [TestMethod]
        public void Swim()
        {
            Assert.AreEqual(DuckMessages.Swim, duck.Swim());
        }
    }
}
