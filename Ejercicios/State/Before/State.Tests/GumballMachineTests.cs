namespace State.Tests
{
    using System;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using State;

    [TestClass]
    public class GumballMachineTests
    {
        private const int NO_GUMBALLS = 0;

        private StringWriter sw;

        [TestInitialize]
        public void Setup()
        {
            this.sw = new StringWriter();
            Console.SetOut(this.sw);
        }

        [TestMethod]
        public void InsertQuarter()
        {
            var gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();

            this.AssertMachineMessage(MachineMessages.InsertSuccessfully);
        }

        [TestMethod]
        public void InsertQuarterTwice()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();

            this.AssertMachineMessage(MachineMessages.InsertTwice);
        }

        [TestMethod]
        public void InsertWhenSoldOut()
        {
            GumballMachine gumballMachine = CreateGumballMachine(NO_GUMBALLS);

            gumballMachine.InsertQuarter();

            this.AssertMachineMessage(MachineMessages.InsertWhenSoldOut);
        }

        [TestMethod]
        public void EjectQuarter()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();

            this.AssertMachineMessage(MachineMessages.EjectSuccessfully);
        }

        [TestMethod]
        public void EjectWhenNoQuarter()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.EjectQuarter();

            this.AssertMachineMessage(MachineMessages.EjectWhenNoQuarter);
        }

        [TestMethod]
        public void EjectWhenSoldOut()
        {
            GumballMachine gumballMachine = CreateGumballMachine(NO_GUMBALLS);

            gumballMachine.EjectQuarter();

            this.AssertMachineMessage(MachineMessages.EjectWhenSoldOut);
        }

        [TestMethod]
        public void TurnWhenSoldOut()
        {
            GumballMachine gumballMachine = CreateGumballMachine(NO_GUMBALLS);

            gumballMachine.TurnCrank();

            this.AssertMachineMessage(MachineMessages.TurnWhenSoldOut);
        }

        [TestMethod]
        public void TurnWhenNoQuarter()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.TurnCrank();

            this.AssertMachineMessage(MachineMessages.TurnWhenNoQuarter);
        }

        [TestMethod]
        public void Dispense()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            this.AssertMachineMessage(MachineMessages.TurnSuccessfully);
            this.AssertMachineMessage(MachineMessages.DispenseSuccessfully);
        }

        [TestMethod]
        public void DispenseTheLastGumball()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            this.AssertMachineMessage(MachineMessages.DispenseTheLastGumball);
        }

        [TestMethod]
        public void DispenseWhenNoQuarter()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.Dispense();

            this.AssertMachineMessage(MachineMessages.DispenseWhenNoQuarter);
        }

        [TestMethod]
        public void DispenseWhenHasQuarter()
        {
            GumballMachine gumballMachine = CreateGumballMachine(1);

            gumballMachine.InsertQuarter();
            gumballMachine.Dispense();

            this.AssertMachineMessage(MachineMessages.DispenseWhenHasQuarter);
        }

        [TestMethod]
        public void DispenseWhenSoldOut()
        {
            GumballMachine gumballMachine = CreateGumballMachine(NO_GUMBALLS);

            gumballMachine.Dispense();

            this.AssertMachineMessage(MachineMessages.DispenseWhenSoldOut);
        }

        private static GumballMachine CreateGumballMachine(int count)
        {
            GumballMachine gumballMachine = new GumballMachine(count);
            return gumballMachine;
        }

        private void AssertMachineMessage(string message)
        {
            Assert.IsTrue(this.sw.ToString().Contains(message));
        }

        [TestCleanup]
        public void TearDown()
        {
            this.sw.Dispose();
        }
    }
}