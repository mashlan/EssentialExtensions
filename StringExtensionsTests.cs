using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialExtensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        [DataRow(" ")]
        public void ShouldReturnTrueForNullOrEmptyString(string data)
        {
            data.IsNullOrEmpty().Should().BeTrue();
        }

        [DataTestMethod]
        [DataRow("hi")]
        [DataRow("this is a test")]
        [DataRow("1")]
        public void ShouldReturnTrueForStringWithValue(string data)
        {
            data.IsNotNullOrEmpty().Should().BeTrue();
        }

        [DataTestMethod]
        [DataRow("1")]
        [DataRow("123456")]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("dude")]
        public void ShouldReturnIntOrDefaultForStingValue(string data)
        {
            var intValue = data.ToIntOrDefault();
            var toInt = int.TryParse(data, out var newInt) ? newInt : 0;
            
            intValue.Should().BeGreaterOrEqualTo(0);
            toInt.Should().Be(intValue);
        }

        [DataTestMethod]
        [DataRow("123456.44")]
        [DataRow(".09")]
        [DataRow("dude")]
        [DataRow(null)]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowExceptionOnNonIntStringValue(string data)
        {
            data.ToIntOrError();
        }

        [DataTestMethod]
        [DataRow("true")]
        [DataRow("True")]
        [DataRow("false")]
        [DataRow("False")]
        public void ShouldReturnBooleanForStringValue(string data)
        {
            var boolValue = data.ToBoolOrDefault();
            bool.TryParse(data, out var newBool);
            boolValue.Should().Be(newBool);
        }

        [DataTestMethod]
        [DataRow("1")]
        [DataRow("0")]
        public void ShouldReturnBooleanForOneOrZeroStringValue(string data)
        {
            var boolValue = data == "1";
            data.ToBoolOrDefault().Should().Be(boolValue);
        }

        [DataTestMethod]
        [DataRow("not true")]
        [DataRow("")]
        [DataRow("falsie")]
        [DataRow("")]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldErrorOnNotBooleanStringValue(string data)
        {
            data.ToBoolOrError();
        }
    }
}
