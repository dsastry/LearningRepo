// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace NUnit.LearningProject
{
    [TestFixture]
    public class TestClass
    {


       [TearDown]
       public void tearDown()
        {
            Console.WriteLine("Closing the project");
        }

        [Test]
        [Ignore("This will be skipped")]

        public void TestMethod()
        {
            // TODO: Add your test code here
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
            Console.WriteLine("Inside Test Method 1");
        }

        [Test]
        public void testLogin()
        {
            Console.WriteLine("In the test Login method");
        }

        [SetUp]
        public void setUp()
        {
            Console.WriteLine("Setup Initialization");

        }
    }
}
