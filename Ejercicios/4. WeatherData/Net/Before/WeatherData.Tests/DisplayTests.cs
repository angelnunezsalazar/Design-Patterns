using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherData.Tests
{
    [TestClass]
    public class DisplayTests
    {
        private StringWriter sw;

        [TestInitialize]
        public void Setup()
        {
            this.sw = new StringWriter();
            Console.SetOut(this.sw);
        }

        [TestMethod]
        public void UpdateDisplay1()
        {
            var weatherData = new WeatherData();
            weatherData.SetMeasurements(80, 65, 30.4f);

            Assert.IsTrue(sw.ToString().Contains("Current conditions: 80F degrees and 65% humidity"));
            Assert.IsTrue(sw.ToString().Contains("Improving weather on the way!"));
            Assert.IsTrue(sw.ToString().Contains("Avg/Max/Min temperature = 80.00F/80F/80F")); 
        }

        [TestMethod]
        public void UpdateDisplay2()
        {
            var weatherData = new WeatherData();
            weatherData.SetMeasurements(82, 70, 29.2f);

            Assert.IsTrue(sw.ToString().Contains("Current conditions: 82F degrees and 70% humidity"));
            Assert.IsTrue(sw.ToString().Contains("Watch out for cooler, rainy weather"));
            Assert.IsTrue(sw.ToString().Contains("Avg/Max/Min temperature = 82.00F/82F/82F"));
        }

        [TestCleanup]
        public void TearDown()
        {
            this.sw.Dispose();
        }
    }
}
