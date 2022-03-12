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
        public void Addi()
        {
            MyMath mm = new MyMath();
            Random r = new Random();
            int a = r.Next(100);
            int b = r.Next(100);
            int expectedOut = a+b;
            int actualOut = mm.Addi(a,b);
            Assert.AreEqual(expectedOut,actualOut);
        }

        [TestCase]
        public void Subi() {
            MyMath mm = new MyMath();
            Random r = new Random();
            int a = r.Next(100);
            int b = r.Next(100);
            int expected = a-b;
            int actual = mm.Subi(a,b);
            Assert.AreEqual(expected, actual);
        }
    }
}
