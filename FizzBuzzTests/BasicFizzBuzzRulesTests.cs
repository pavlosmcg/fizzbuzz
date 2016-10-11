using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class BasicFizzBuzzRulesTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(91, "91")]
        public void TakeTurn_ReturnsStringForInteger(int input, string expectedResult)
        {
            var unitUnderTest = new BasicFizzBuzzRules();

            var result = unitUnderTest.TakeTurn(input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(3)]
        [TestCase(9)]
        [TestCase(99)]
        public void TakeTurn_ReturnsFizz_WhenInputIsDivisibleByThree(int input)
        {
            var unitUnderTest = new BasicFizzBuzzRules();

            var result = unitUnderTest.TakeTurn(input);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(100)]
        public void TakeTurn_ReturnsBuzz_WhenInputIsDivisibleByFive(int input)
        {
            var unitUnderTest = new BasicFizzBuzzRules();

            var result = unitUnderTest.TakeTurn(input);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(450)]
        public void TakeTurn_ReturnsFizzBuzz_WhenInputIsDivisibleByFive(int input)
        {
            var unitUnderTest = new BasicFizzBuzzRules();

            var result = unitUnderTest.TakeTurn(input);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
    }
}
