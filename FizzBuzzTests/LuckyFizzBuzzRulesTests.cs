using FizzBuzz;
using NSubstitute;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class LuckyFizzBuzzRulesTests
    {
        private readonly IFizzBuzzRules _wrappedFizzBuzzRules = Substitute.For<IFizzBuzzRules>();

        [SetUp]
        public void SetUp()
        {
            _wrappedFizzBuzzRules.TakeTurn(Arg.Any<int>()).Returns("framistan");
        }

        [TestCase(3)]
        [TestCase(33)]
        [TestCase(123)]
        public void TakeTurn_ReturnsLucky_WhenInputContains3(int input)
        {
            var unitUnderTest = new LuckyFizzBuzzRules(_wrappedFizzBuzzRules);

            var result = unitUnderTest.TakeTurn(input);

            Assert.That(result, Is.EqualTo("Lucky"));
        }

        [TestCase(1)]
        [TestCase(15)]
        [TestCase(64)]
        public void TakeTurn_ReturnsResultFromWrappedFizzBuzzer_WhenInputDoesNotContain3(int input)
        {
            var unitUnderTest = new LuckyFizzBuzzRules(_wrappedFizzBuzzRules);

            var result = unitUnderTest.TakeTurn(input);

            Assert.That(result, Is.EqualTo("framistan"));
        }
    }
}
