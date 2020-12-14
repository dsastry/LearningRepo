using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.LearningProject
{
    [TestFixture]
    public class ParameterizedDataTest
    {
        [Test]
        [TestCaseSource("data")]

        public void TestMethod(string username, string password, string email, string city)
        {
            Console.WriteLine(username +" <--> "+ password + " <--> " + email + " <--> " + city);   
        }

        public static object[] data()
        {
            object[][] data = new object[3][];
            data[0] = new object[4];
            data[0][0] = "User1";
            data[0][1] = "pass1";
            data[0][2] = "email";
            data[0][3] = "city";

            data[1] = new object[4];
            data[1][0] = "User2";
            data[1][1] = "pass2";
            data[1][2] = "email2";
            data[1][3] = "cit2";

            data[2] = new object[4];
            data[2][0] = "User2";
            data[2][1] = "pass2";
            data[2][2] = "email2";
            data[2][3] = "city2";

            return data;
        }

        [Test]
        public void testAsserts()

        {
            Assert.AreEqual("Test1","Test2");

        }

        [Test]
        public void testAsserts1()

        {
            Assert.IsTrue(4<5, "Value is not right");

        }
    }
}
