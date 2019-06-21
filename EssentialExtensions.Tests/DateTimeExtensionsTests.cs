using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialExtensions.Tests
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        public void DateShouldReturnTrueOnIsAfter()
        {
            DateTime.Today.AddDays(5).IsAfter(DateTime.Today).Should().BeTrue();
        }

        [TestMethod]
        public void DateShouldReturnTrueOnIsAfterWithoutTimeSpan()
        {
            DateTime.Today.AddDays(4).IsAfter(DateTime.Today, true).Should().BeTrue();
        }

        [TestMethod]
        public void NullableDateShouldReturnTrueOnIsAfter()
        {
            DateTime? date = DateTime.Today.AddDays(5);
            date.IsAfter(DateTime.Today).Should().BeTrue();
        }

        [TestMethod]
        public void NullableDateShouldReturnTrueOnIsAfterWithoutTimeSpan()
        {
            DateTime? date = DateTime.Today.AddDays(5);
            date.IsAfter(DateTime.Today, true).Should().BeTrue();
        }

        [TestMethod]
        public void DateShouldReturnTrueOnIsBefore()
        {
            DateTime.Today.AddDays(-5).IsBefore(DateTime.Today).Should().BeTrue();
        }

        [TestMethod]
        public void DateShouldReturnTrueOnIsBeforeWithoutTimeSpan()
        {
            DateTime.Today.AddDays(-4).IsBefore(DateTime.Today, true).Should().BeTrue();
        }

        [TestMethod]
        public void NullableDateShouldReturnTrueOnIsBefore()
        {
            DateTime? date = DateTime.Today.AddDays(-5);
            date.IsBefore(DateTime.Today).Should().BeTrue();
        }

        [TestMethod]
        public void NullableDateShouldReturnTrueOnIsBeforeWithoutTimeSpan()
        {
            DateTime? date = DateTime.Today.AddDays(-5);
            date.IsBefore(DateTime.Today, true).Should().BeTrue();
        }

        [TestMethod]
        public void DateShouldReturnTrueIfToday()
        {
            DateTime.Today.IsToday().Should().BeTrue();
        }

        [TestMethod]
        public void NullableDateShouldReturnTrueIfToday()
        {
            DateTime? today = DateTime.Today;
            today.IsToday().Should().BeTrue();
        }

        [TestMethod]
        public void DateShouldReturnFalseIfIsPastDate()
        {
            DateTime.Today.AddDays(-2).IsToday().Should().BeFalse();
        }

        [TestMethod]
        public void DateShouldReturnFalseIfIsFutureDate()
        {
            DateTime.Today.AddDays(2).IsToday().Should().BeFalse();
        }

        [TestMethod]
        public void NullableDateShouldReturnFalseIfPastDate()
        {
            DateTime? date = DateTime.Today.AddDays(-2);
            date.IsToday().Should().BeFalse();
        }

        [TestMethod]
        public void NullableDateShouldReturnFalseIfFutureDate()
        {
            DateTime? date = DateTime.Today.AddDays(2);
            date.IsToday().Should().BeFalse();
        }
    }
}
