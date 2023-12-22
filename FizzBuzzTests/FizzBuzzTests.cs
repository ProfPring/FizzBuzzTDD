using FizzBuzzTDD.Helpers;
using FizzBuzzTDD.Helpers.Interfaces;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Moq;
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
        private readonly IFizBuzzHelper _fizBuzzHelper;

        public FizzBuzzTests()
        {
            _fizBuzzHelper = new FizBuzzHelper();
        }

        [Test]
        public void FizzBuzz_GenerateOutput_DivisibleBy3()
        {
            // Act
            var output = _fizBuzzHelper.IsDivisibleByThree(3);

            // Assert
            Assert.That(output, Is.EqualTo("Fizz"));
        }

        [Test]
        public void FizzBuzz_GenerateOutput_DivisibleBy5()
        {
            // Arrange

            // Act
            

            // Assert
            
        }

        [Test]
        public void FizzBuzz_GenerateOutput_DivisibleBy3And5()
        {
            // Arrange

            // Act
            

            // Assert
        }

        [Test]
        public void FizzBuzz_GenerateOutput_NotDivisibleBy3Or5()
        {
            // Arrange
            

            // Act
            

            // Assert
        }
    }
}
