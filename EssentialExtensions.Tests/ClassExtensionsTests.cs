using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialExtensions.Tests
{
    [TestClass]
    public class ClassExtensionsTests
    {
        [TestMethod]
        public void ShouldCreateCloneOfSimpleObject()
        {
            var testDummy = TestDummy.CreateDummy();
            var cloneDummy = testDummy.Clone();

            cloneDummy.Should().NotBeNull();
            cloneDummy.Should().NotBe(testDummy);

            cloneDummy.Age.Should().Be(testDummy.Age);
            cloneDummy.Name.Should().Be(testDummy.Name);
            cloneDummy.IsDummy.Should().Be(testDummy.IsDummy);
            cloneDummy.BirthDate.Should().Be(testDummy.BirthDate);

            //test is not a ref object
            cloneDummy.Age = 101;
            cloneDummy.Age.Should().NotBe(testDummy.Age);
        }

        [TestMethod]
        public void ShouldCreateCloneOfComplexObject()
        {
            var testDummy = TestDummy.CreateDummyWithChild();
            var cloneDummy = testDummy.Clone();

            cloneDummy.Should().NotBeNull();
            cloneDummy.Child.Should().NotBeNull();
            cloneDummy.Child.Friends.Should().NotBeEmpty();
            cloneDummy.Should().NotBeSameAs(testDummy);
            cloneDummy.Child.Should().NotBeSameAs(testDummy.Child);
        }
        
        [TestMethod]
        public void ShouldReturnTrueIfObjectIsNull()
        {
            TestDummy testDummy = null;
            testDummy.IsNull().Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnFalseIfObjectIsNotNull()
        {
            TestDummy.CreateDummy().IsNull().Should().BeFalse();
        }

        [TestMethod]
        public void ShouldReturnTrueIfObjectIsNotNull()
        {
            TestDummy.CreateDummy().IsNotNull().Should().BeTrue();
        }

        [TestMethod]
        public void ShouldReturnFalseIfObjectIsNull()
        {
            TestDummy testDummy = null;
            testDummy.IsNotNull().Should().BeFalse();
        }

        [TestMethod]
        public void ShouldSerializeToXml()
        {
            TestDummy.CreateDummy().SerializeToXml().Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public void ShouldConvertObjectToJObject()
        {
            var testDummy = TestDummy.CreateDummy();
            var jObject = testDummy.ToJObject();

            jObject.Should().NotBeNull();
            ((int)jObject[nameof(TestDummy.Age)]).Should().Be(testDummy.Age);
        }

        [TestMethod]
        public void ShouldConvertObjectToJsonString()
        {
            TestDummy.CreateDummyWithChild().ToJson().Should().NotBeNullOrEmpty();
        }

        #region TestData

        public class TestDummy
        {
            public static TestDummy CreateDummy()
            {
                return new TestDummy
                {
                    Age = 25,
                    Name = "Test Dummy",
                    PhoneNumber = "2455554444",
                    IsDummy = false,
                    BirthDate = DateTime.Today.AddYears(-25)
                };
            }

            public static TestDummy CreateDummyWithChild()
            {
                var dummy = CreateDummy();
                dummy.Child = TestDummyChild.CreateTestDummyChild();
                return dummy;
            }

            public string Name { get; set; }

            public string PhoneNumber { get; set; }

            public int Age { get; set; }

            public bool IsDummy { get; set; }

            public DateTime BirthDate { get; set; }

            public TestDummyChild Child { get; set; }
        }

        public class TestDummyChild
        {
            public static TestDummyChild CreateTestDummyChild()
            {
                return new TestDummyChild
                {
                    ChildName = "Baby Jane",
                    Friends = new List<string> {"Joe", "Mary", "Peter", "Paul"}
                };
            }

            public string ChildName { get; set; }
            
            public List<string> Friends { get; set; }
        }

        #endregion
    }
}
