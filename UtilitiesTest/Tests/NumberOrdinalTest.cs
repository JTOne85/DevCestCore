using NUnit.Framework;
using UtilitiesCore.Interfaces;

namespace InterviewTests
{
    [TestFixture]
    public class NumberOrdinalTest
    {
        [TestCase(1, "1st")]
        [TestCase(2, "2nd")]
        [TestCase(3, "3rd")]
        [TestCase(4, "4th")]
        [TestCase(20, "20th")]
        [TestCase(21, "21st")]
        [TestCase(22, "22nd")]
        [TestCase(23, "23rd")]
        [TestCase(24, "24th")]
        public void NumberOrdinal(int input, string expectedResult)
        {
            // Arrange
            IOrdinalHelper ordinalHelper = null;
            
            // Act
            var result = ordinalHelper.GetNumberWithOrdinal(input);
            
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}