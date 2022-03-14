using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_IoT
{
    [TestFixture]
    class MyTestCase
    {
        [TestCase]
        public void TestAddition()
        {
            MyMath mm = new MyMath();
            Random r = new Random();
            int a = r.Next(100);
            int b = r.Next(100);
            int expectedOut = a + b;
            int actualOut = mm.Addition(a, b);
            Assert.AreEqual(expectedOut, actualOut);
        }

        [TestCase]
        public void TestSubtraction()
        {
            MyMath mm = new MyMath();
            Random r = new Random();
            int a = r.Next(100);
            int b = r.Next(100);
            int expected = a - b;
            int actual = mm.Subtraction(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase]
        public void TestMultiplication()
        {
            MyMath mm = new MyMath();
            Random r = new Random();
            int a = r.Next(100);
            int b = r.Next(100);
            int expected = a * b;
            int actual = mm.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase]
        public void TestDivisionWithNonZero()
        {
            MyMath mm = new MyMath();
            Random r = new Random();
            double a = r.NextDouble();
            double b = r.NextDouble();

            if (b==0)
            {
                b += 1;
            }
            double expected = a / b;
            double actual = mm.Division(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void TestDivisionWithZero()
        {
            MyMath mm = new MyMath();
            Random r = new Random();
            double a = r.NextDouble();
            double b = 0;
            string expectedErrorMessage = "Divide By Zero Error";
            
            var ex = Assert.Throws<ArithmeticException>(() => mm.Division(a, b));

            Assert.AreEqual(expectedErrorMessage, ex.Message);
            
        }


    }
}
