using System;
using System.Linq;
using FizzBuzz;
using NSubstitute;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzRunnerTests
    {
        private readonly IFizzBuzzRules _fizzBuzzRules = Substitute.For<IFizzBuzzRules>();

        [SetUp]
        public void SetUp()
        {
            _fizzBuzzRules.TakeTurn(Arg.Any<int>()).Returns("blorgfester");
        }

        [Test]
        public void Run_ReturnsExpectedValuesFromRulesDependency_WhenInputIsValid()
        {
            var unitUnderTest = new FizzBuzzRunner(_fizzBuzzRules);

            var result = unitUnderTest.Run("1", "3").ToArray();

            Assert.That(result, Is.EquivalentTo(new[] { "blorgfester", "blorgfester", "blorgfester" }));
        }

        [TestCase("1", "20", 20)]
        [TestCase("6", "10", 5)]
        [TestCase("3", "3", 1)]
        public void Run_ReturnsExpectedNumberOfResultsFromRulesDependency_WhenInputIsValid(string start, string end, int expectedNumberOfResults)
        {
            var unitUnderTest = new FizzBuzzRunner(_fizzBuzzRules);

            var result = unitUnderTest.Run(start, end).ToArray();

            Assert.That(result.Length, Is.EqualTo(expectedNumberOfResults));
        }

        [Test]
        public void Run_ThrowsArgumentNullException_WhenStartIsNull()
        {
            var unitUnderTest = new FizzBuzzRunner(_fizzBuzzRules);

            Assert.Throws<ArgumentNullException>(() => unitUnderTest.Run(null, "15").ToArray());
        }

        [Test]
        public void Run_ThrowsArgumentNullException_WhenEndIsNull()
        {
            var unitUnderTest = new FizzBuzzRunner(_fizzBuzzRules);

            Assert.Throws<ArgumentNullException>(() => unitUnderTest.Run("1", null).ToArray());
        }

        [TestCase("1", "abc")]
        [TestCase("1.5", "20")]
        public void Run_ThrowsArgumentException_WhenArgumentsAreNotIntegers(string start, string end)
        {
            var unitUnderTest = new FizzBuzzRunner(_fizzBuzzRules);

            Assert.Throws<ArgumentException>(() => unitUnderTest.Run(start, end).ToArray());
        }

        [TestCase("0", "10")]
        [TestCase("-1", "10")]
        [TestCase("20", "10")]
        public void Run_ThrowsArgumentOutOfRangeException_WhenArgsStartAndEndValuesAreOutOfRange(string start, string end)
        {
            var unitUnderTest = new FizzBuzzRunner(_fizzBuzzRules);

            Assert.Throws<ArgumentOutOfRangeException>(() => unitUnderTest.Run(start, end).ToArray());
        }
    }
}
