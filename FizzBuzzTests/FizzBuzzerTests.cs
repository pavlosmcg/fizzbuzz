using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Run_ThrowsArgumentNullException_WhenStartIsNull()
        {
            var unitUnderTest = new FizzBuzzer();

            Assert.Throws<ArgumentNullException>(() => unitUnderTest.Run(null, "15"));
        }

        [Test]
        public void Run_ThrowsArgumentNullException_WhenEndIsNull()
        {
            var unitUnderTest = new FizzBuzzer();

            Assert.Throws<ArgumentNullException>(() => unitUnderTest.Run("1", null));
        }

        [TestCase("1", "abc")]
        [TestCase("1.5", "20")]
        public void Run_ThrowsArgumentException_WhenArgumentsAreNotIntegers(string start, string end)
        {
            var unitUnderTest = new FizzBuzzer();

            Assert.Throws<ArgumentException>(() => unitUnderTest.Run(start, end));
        }

        [TestCase("0", "10")]
        [TestCase("-1", "10")]
        [TestCase("20", "10")]
        public void Run_ThrowsArgumentOutOfRangeException_WhenArgsStartAndEndValuesAreOutOfRange(string start, string end)
        {
            var unitUnderTest = new FizzBuzzer();

            Assert.Throws<ArgumentOutOfRangeException>(() => unitUnderTest.Run(start, end));
        }
    }
}
