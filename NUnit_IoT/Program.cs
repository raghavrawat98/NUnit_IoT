using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_IoT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.ReadLine();
            double a = 10;
            double b = 0;
            MyMath mm = new MyMath();
            Console.WriteLine(mm.Division(a, b));
            Console.WriteLine(mm.Division(a, b).GetType());

        }
    }
}
