using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_IoT
{
    class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("Exception has occured");
        }
    }
    public class MyMath
    {
        public int Addition(int a, int b) {
            return a + b;
        }

        public int Subtraction(int a, int b) {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public double Division(int a, int b)
        {
            if (b == 0)
            {
                throw new MyException();
            }
            double r = a / b;
            return r;
        }
    }
}
