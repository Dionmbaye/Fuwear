using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fizzbuzz.npi.test
{
    [TestClass]
    public class FizzBuzzNpiUnitTest
    {
        FizzBuzzNpiClass _fizzBuzzNpi = new FizzBuzzNpiClass();
        [TestMethod]
        public void TestFizzBuzz_Should_Return_Fizz_When_6()
        {
            //Arrange
            var input = 6;

            //Act
            var result = _fizzBuzzNpi.FizzBuzz(input);

            //Assert
            Assert.AreEqual(result, "Fizz");

        }

        [TestMethod]
        public void TestFizzBuzz_Should_Return_Buzz_When_25()
        {
            //Arrange
            var input = 25;

            //Act
            var result = _fizzBuzzNpi.FizzBuzz(input);

            //Assert
            Assert.AreEqual(result, "Buzz");

        }

        [TestMethod]
        public void TestFizzBuzz_Should_Return_FizzBuzz_When_15()
        {
            //Arrange
            var input = 15;

            //Act
            var result = _fizzBuzzNpi.FizzBuzz(input);

            //Assert
            Assert.AreEqual(result, "FizzBuzz");

        }

        [TestMethod]
        public void TestFizzBuzz_Should_Return_7_When_7()
        {
            //Arrange
            var input = 7;

            //Act
            var result = _fizzBuzzNpi.FizzBuzz(input);

            //Assert
            Assert.AreEqual(result, "7");

        }

    }

}