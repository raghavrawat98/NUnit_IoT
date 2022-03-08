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
            int expectedOut = 31;
            int actualOut = mm.Addi(20,11);
            Assert.AreEqual(expectedOut,actualOut);
        }

        [TestCase]
        public void Subi() {
            MyMath mm = new MyMath();
            int expected = 10;
            int actual = mm.Subi(30,20);
            Assert.AreEqual(expected, actual);
        }
    }
}
