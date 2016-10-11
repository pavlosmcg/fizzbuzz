using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class ResultsReporterTests
    {
        [Test]
        public void CreateReport_ReturnsCollectionContainingNumberOfIntegers()
        {
            var fizzBuzzResults = new[] {"1", "11", "56"};
            var unitUnderTest = new ResultsReporter();

            var reportItems = unitUnderTest.CreateReport(fizzBuzzResults);

            Assert.That(reportItems["integer"], Is.EqualTo(3));
        }

        [Test]
        public void CreateReport_ReturnsCollectionContainingNumberOfOtherItems()
        {
            var fizzBuzzResults = new[] { "1", "2", "blorg", "blorg", "fester", "donkey" };
            var unitUnderTest = new ResultsReporter();

            var reportItems = unitUnderTest.CreateReport(fizzBuzzResults);

            Assert.That(reportItems["integer"], Is.EqualTo(2));
            Assert.That(reportItems["blorg"], Is.EqualTo(2));
            Assert.That(reportItems["fester"], Is.EqualTo(1));
            Assert.That(reportItems["donkey"], Is.EqualTo(1));
        }
    }
}
