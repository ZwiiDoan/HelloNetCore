using HelloNetCore.entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
