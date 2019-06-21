using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialExtensions.Tests
{
    [TestClass]
    public class IntegerExtensionsTests
    {
        [TestMethod]
        public void ShouldReturnNullableIntValueAsString()
        {
            int? integer = 10;
            integer.ToDefaultString().Should().Be("10");
        }

        [TestMethod]
        public void ShouldReturn0AsStringForNullableIntNotSet()
        {
            int? integer = null;
            integer.ToDefaultString().Should().Be("0");
        }

        [TestMethod]
        public void ShouldReturnTrueForIntegerThatIsGreaterThan()
        {
            10.IsGreaterThan(8).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnFalseForIntegerThatIsGreaterThan()
        {
            10.IsGreaterThan(20).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldReturnFalseForIntegerThatIsLessThan()
        {
            10.IsLessThan(5).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldReturnTrueForIntegerThatIsLessThan()
        {
            10.IsLessThan(20).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnTrueForNullableIntegerThatIsGreaterThan()
        {
            int? integer = 10;
            integer.IsGreaterThan(8).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnFalseForNullableIntegerThatIsGreaterThan()
        {
            int? integer = 10;
            integer.IsGreaterThan(20).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldReturnFalseForNullableIntegerThatIsLessThan()
        {
            int? integer = 10;
            integer.IsLessThan(5).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldReturnTrueForNullableIntegerThatIsLessThan()
        {
            int? integer = 10;
            integer.IsLessThan(20).Should().BeTrue();
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(8)]
        public void ShouldReturnTrueForIntegerThatIsGreaterThanOrEqual(int data)
        {
            data.IsGreaterThanOrEqual(8).Should().BeTrue();
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(19)]
        public void ShouldReturnFalseForIntegerThatIsGreaterThanOrEqual(int data)
        {
            data.IsGreaterThanOrEqual(20).Should().BeFalse();
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(6)]
        public void ShouldReturnFalseForIntegerThatIsLessThanOrEqual(int data)
        {
            data.IsLessThanOrEqual(5).Should().BeFalse();
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(20)]
        public void ShouldReturnTrueForIntegerThatIsLessThanOrEqual(int data)
        {
            data.IsLessThanOrEqual(20).Should().BeTrue();
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(8)]
        public void ShouldReturnTrueForNullableIntegerThatIsGreaterThanOrEqual(int? data)
        {
            data.IsGreaterThanOrEqual(8).Should().BeTrue();
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(8)]
        public void ShouldReturnFalseForNullableIntegerThatIsGreaterThanOrEqual(int? data)
        {
            data.IsGreaterThanOrEqual(20).Should().BeFalse();
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(8)]
        public void ShouldReturnFalseForNullableIntegerThatIsLessThanOrEqual(int? data)
        {
            data.IsLessThanOrEqual(5).Should().BeFalse();
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(20)]
        public void ShouldReturnTrueForNullableIntegerThatIsLessThanOrEqual(int? data)
        {
            data.IsLessThanOrEqual(20).Should().BeTrue();
        }

    }
}
