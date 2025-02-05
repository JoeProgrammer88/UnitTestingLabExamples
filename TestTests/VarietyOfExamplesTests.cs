using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    [TestClass()]
    public class VarietyOfExamplesTests
    {
        [TestMethod()]
        [DataRow(2000)]
        [DataRow(2004)]
        [DataRow(2048)]
        [DataRow(1584)]
        public void IsLeapYear_ValidLeapYear_ReturnsTrue(int yearToTest)
        {
            // Arrange

            // Act
            VarietyOfExamples varietyOfExamples = new VarietyOfExamples();
            bool result = varietyOfExamples.IsLeapYear(yearToTest);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow(2001)]
        [DataRow(2003)]
        [DataRow(1900)]
        [DataRow(2100)]
        [DataRow(2002)]
        public void IsLeapYear_ValidNonLeapYear_ReturnsFalse(int yearToTest)
        {
            // Arrange

            // Act
            VarietyOfExamples varietyOfExamples = new VarietyOfExamples();
            bool result = varietyOfExamples.IsLeapYear(yearToTest);

            // Assert
            Assert.IsFalse(result);
        }
    }
}