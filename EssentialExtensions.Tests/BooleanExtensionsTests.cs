using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialExtensions.Tests
{
    [TestClass]
    public class BooleanExtensionsTests
    {
        [TestMethod]
        public void ShouldConvertNullBooleanToEmptyString()
        {
            bool? boolean = null;
            var str = boolean.ToString();

            str.Should().Be(string.Empty);
        }

        [TestMethod]
        public void ShouldConvertTrueToString()
        {
            bool? boolean = true;
            boolean.ToString().Should().Be("True");
        }

        [TestMethod]
        public void ShouldConvertNullToFalseString()
        {
            bool? boolean = null;
            boolean.ToDefaultString().Should().Be("False");
        }

        [TestMethod]
        public void ShouldConvertFalseToFalseString()
        {
            bool? boolean = false;
            boolean.ToDefaultString().Should().Be("False");
        }

        [TestMethod]
        public void ShouldConvertTrueToTrueString()
        {
            bool? boolean = true;
            boolean.ToDefaultString().Should().Be("True");
        }

        [TestMethod]
        public void ShouldReturnTrueForNullableBooleanSetToTrue()
        {
            bool? boolean = true;
            boolean.IsTrue().Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnFalseForNullableBooleanSetToFalse()
        {
            bool? boolean = false;
            boolean.IsTrue().Should().BeFalse();
        }

        [TestMethod]
        public void ShouldReturnTrueForNullableBooleanSetToFalse()
        {
            bool? boolean = false;
            boolean.IsFalse().Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnFalseForNullableBooleanSetToTrue()
        {
            bool? boolean = true;
            boolean.IsFalse().Should().BeFalse();
        }

        [TestMethod]
        public void ShouldReturn1AsStringForBooleanSetToTrue()
        {
            true.ToBitString().Should().Be("1");
        }

        [TestMethod]
        public void ShouldReturn0AsStringForBooleanSetToFalse()
        {
            false.ToBitString().Should().Be("0");
        }

        [TestMethod]
        public void ShouldReturn1AsStringForNullableBooleanSetToTrue()
        {
            bool? boolean = true;
            boolean.ToBitString().Should().Be("1");
        }

        [TestMethod]
        public void ShouldReturn0AsStringForNullableBooleanSetToFalse()
        {
            bool? boolean = false;
            boolean.ToBitString().Should().Be("0");
        }

        [TestMethod]
        public void ShouldReturn0AsStringForNullableBooleanNotSet()
        {
            bool? boolean = null;
            boolean.ToBitString().Should().Be("0");
        }

        [TestMethod]
        public void ShouldReturn1AsIntForBooleanSetToTrue()
        {
            true.ToInteger().Should().Be(1);
        }

        [TestMethod]
        public void ShouldReturn0AsIntForBooleanSetToFalse()
        {
            false.ToInteger().Should().Be(0);
        }

        [TestMethod]
        public void ShouldReturn1AsIntForNullableBooleanSetToTrue()
        {
            bool? boolean = true;
            boolean.ToInteger().Should().Be(1);
        }

        [TestMethod]
        public void ShouldReturn0AsIntForNullableBooleanSetToFalse()
        {
            bool? boolean = false;
            boolean.ToInteger().Should().Be(0);
        }

        [TestMethod]
        public void ShouldReturn0AsIntForNullableBooleanNotSet()
        {
            bool? boolean = null;
            boolean.ToInteger().Should().Be(0);
        }

    }
}
