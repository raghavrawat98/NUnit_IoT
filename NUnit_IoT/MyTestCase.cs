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
            double a = r.NextDouble()*10;
            double b = r.NextDouble()*10;
            double expectedOut = a + b;
            double actualOut = mm.Addition(a, b);
            Assert.AreEqual(expectedOut, actualOut);
        }

        [TestCase]
        public void TestSubtraction()
        {
            MyMath mm = new MyMath();
            Random r = new Random();
            double a = r.NextDouble() * 10;
            double b = r.NextDouble() * 10;
            double expected = a - b;
            double actual = mm.Subtraction(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase]
        public void TestMultiplication()
        {
            MyMath mm = new MyMath();
            Random r = new Random();
            double a = r.NextDouble() * 10;
            double b = r.NextDouble() * 10;
            double expected = a * b;
            double actual = mm.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase]
        public void TestDivisionWithNonZero()
        {
            MyMath mm = new MyMath();
            Random r = new Random();
            double a = r.NextDouble()*10;
            double b = r.NextDouble()*10;

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
