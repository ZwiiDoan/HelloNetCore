using HelloNetCore.entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestHelloNetCore
{
    [TestClass]
    public class DataTypeTest
    {
        [TestMethod]
        public void TestReferenceType()
        {
            GradeBook GradeBook1 = new GradeBook();
            GradeBook1.Name = "GradeBook1";

            GradeBook GradeBook2 = GradeBook1;
            GradeBook2.Name = "GradeBook2";

            Assert.AreEqual(GradeBook1.Name, GradeBook2.Name);
            Assert.AreEqual(GradeBook1.Name, "GradeBook2");

            string string1 = "string1";
            string string2 = string1;
            string2 = "string2";
            Assert.AreNotEqual(string1, string2);
            Assert.AreEqual(string1, "string1");
        }

        [TestMethod]
        public void TestValueType()
        {
            int value1 = 1;
            int value2 = value1;

            value2 = 2;

            Assert.AreNotEqual(value1, value2);
        }

        [TestMethod]
        public void TestPassByRef()
        {
            int i = 1;
            int j = 1;

            Increment(out i, j);
            Assert.AreEqual(i, 2);
        }

        private void Increment(out int i, int j)
        {
            i = j + 1;
        }

        [TestMethod]
        public void TestImmutableType()
        {
            DateTime dateTime = new DateTime(2018, 01, 01);
            DateTime laterDateTime = dateTime.AddDays(1.5);
            Assert.AreNotEqual(dateTime, laterDateTime);
            Assert.AreEqual(dateTime, new DateTime(2018, 01, 01));

            string immutableString = "String is a reference type but it is immutable";
            string newString = immutableString.Replace(" ", "_");
            Assert.AreNotEqual(newString, immutableString);
            Assert.AreEqual(immutableString, "String is a reference type but it is immutable");
        }
    }
}
