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
            var result = _fizzBuzzNpi.ComputeFizzBuzz(input);

            //Assert
            Assert.AreEqual(result, "Fizz");

        }

        [TestMethod]
        public void TestFizzBuzz_Should_Return_Buzz_When_25()
        {
            //Arrange
            var input = 25;

            //Act
            var result = _fizzBuzzNpi.ComputeFizzBuzz(input);

            //Assert
            Assert.AreEqual(result, "Buzz");

        }

        [TestMethod]
        public void TestFizzBuzz_Should_Return_FizzBuzz_When_15()
        {
            //Arrange
            var input = 15;

            //Act
            var result = _fizzBuzzNpi.ComputeFizzBuzz(input);

            //Assert
            Assert.AreEqual(result, "FizzBuzz");

        }

        [TestMethod]
        public void TestFizzBuzz_Should_Return_7_When_7()
        {
            //Arrange
            var input = 7;

            //Act
            var result = _fizzBuzzNpi.ComputeFizzBuzz(input);

            //Assert
            Assert.AreEqual(result, "7");

        }

        [TestMethod]
        public void TestNpi_Should_Return_1_When_1()
        {
            //Arrange
            var input = "1";

            //Act
            var result = _fizzBuzzNpi.ComputeNpi(input);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestNpi_Should_Return_4_When_1_3_Plus()
        {
            //Arrange
            var input = "1 3 +";

            //Act
            var result = _fizzBuzzNpi.ComputeNpi(input);

            //Assert
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void TestNpi_Should_Return_6_When_3_2_Mult()
        {
            //Arrange
            var input = "3 2 x";

            //Act
            var result = _fizzBuzzNpi.ComputeNpi(input);

            //Assert
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void TestNpi_Should_Return_18_When_2_3_6_Plus_Mult()
        {
            //Arrange
            var input = "2 3 6 + x";

            //Act
            var result = _fizzBuzzNpi.ComputeNpi(input);

            //Assert
            Assert.AreEqual(result, 18);
        }

    }

}