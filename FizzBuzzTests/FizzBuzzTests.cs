using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        public FizzBuzzTests()
        {

        }

        [Test]
        public void FizzBuzz_GenerateOutput_DivisibleBy3()
        {
            // Arrange
            

            // Act
            string output = fizzBuzzGenerator.GenerateFizzBuzzOutput(9, 9); // 9 is divisible by 3
            consoleOutput.Print(output);

            // Assert
            string[] outputLines = consoleOutputString.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("Fizz", outputLines[0]);
        }

        [Test]
        public void FizzBuzz_GenerateOutput_DivisibleBy5()
        {
            // Arrange

            // Act
            string output = fizzBuzzGenerator.GenerateFizzBuzzOutput(10, 10); // 10 is divisible by 5
            consoleOutput.Print(output);

            // Assert
            string[] outputLines = consoleOutputString.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("Buzz", outputLines[0]);
        }

        [Test]
        public void FizzBuzz_GenerateOutput_DivisibleBy3And5()
        {
            // Arrange

            // Act
            string output = fizzBuzzGenerator.GenerateFizzBuzzOutput(15, 15); // 15 is divisible by both 3 and 5
            consoleOutput.Print(output);

            // Assert
            string[] outputLines = consoleOutputString.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("FizzBuzz", outputLines[0]);
        }

        [Test]
        public void FizzBuzz_GenerateOutput_NotDivisibleBy3Or5()
        {
            // Arrange
            

            // Act
            string output = fizzBuzzGenerator.GenerateFizzBuzzOutput(7, 7); // 7 is not divisible by 3 or 5
            consoleOutput.Print(output);

            // Assert
            string[] outputLines = consoleOutputString.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("7", outputLines[0]);
        }
    }
}
