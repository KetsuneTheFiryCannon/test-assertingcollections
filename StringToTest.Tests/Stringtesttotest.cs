using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CollectionToSqrt;

namespace StringToTest.Tests
{
    [TestClass]
    public class Stringtesttotest
    {
        static List<string> employees = Collectiontosqrt.fwee();
        static List<string> employeer = new List<string>();

        [ClassInitialize]
        public static void InitiallizeCurrentTest(TestContext testContext)
        {
            employeer = new List<string>();

            employeer.Add("a");
            employeer.Add("b");
            employeer.Add("c");
            employeer.Add("d");
            employeer.Add("e");
            employeer.Add("f");
            employeer.Add("g");
        }

        [TestMethod]
        public void StringTestNotNullUniqueEqual()
        {
            List<string> employeetest = new List<string>();

            employeetest.Add("a");
            employeetest.Add("b");
            employeetest.Add("c");
            employeetest.Add("d");
            employeetest.Add("e");
            employeetest.Add("f");
            employeetest.Add("g");

            //CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");
            //CollectionAssert.AllItemsAreUnique(employees, "Uniqueness failed");
            CollectionAssert.AreEqual(employeer, employeetest);
        }

        [TestMethod]
        public void StringTestNotNullUniqueEquivalent()
        {
            List<string> employeetest = new List<string>();

            employeetest.Add("a");
            employeetest.Add("b");
            employeetest.Add("c");
            employeetest.Add("d");
            employeetest.Add("e");
            employeetest.Add("g");
            employeetest.Add("f");

            //CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");
            //CollectionAssert.AllItemsAreUnique(employees, "Uniqueness failed");
            CollectionAssert.AreEquivalent(employees, employeetest);
        }

        [TestMethod]
        public void DoubleToDelta()
        {
            double a = 123;
            double d = 10;

            double expected = 12.0;
            double delta = 0.4;

            double actual = Collectiontosqrt.MySqrt(a, d);
            Assert.AreEqual(expected, actual, delta, "fail message");
        }

        //[TestMethod]
        //public void TestCounter()
        //{
        //    double expected = 2;
        //    double delta = 0.9;
        //    Assert.AreEqual(expected, Collectiontosqrt.TestCount(), delta, "Fail");
        //}
    }
}