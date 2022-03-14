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
            string continueCal= "y";
            string operation = "";

            var answer=0.0;

            var firstNum = 0.0;
            var secondNum = 0.0;

            while (continueCal.Equals("y")) {
                Console.WriteLine("Enter first Number and press Enter");
                //var firstNum = double.Parse(Console.ReadLine());
                try
                {
                    firstNum = double.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }


                Console.WriteLine("Enter Second Number and press Enter");
                try
                {
                    secondNum = double.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                

                MyMath calculator = new MyMath();
                //Console.WriteLine("fnum: {0} snum:{1}",fnum,snum);

                //choose operation
                Console.WriteLine("\t For Addition type + and enter");
                Console.WriteLine("\t For Subtraction type - and enter");
                Console.WriteLine("\t For Multiplication type * and enter");
                Console.WriteLine("\t For Division type / and enter");
                operation = Console.ReadLine();

                switch (operation) {
                    case "+":
                        answer = calculator.Addition(firstNum, secondNum);
                        Console.WriteLine("Answer := {0}", answer);
                        break;
                    case "-":
                        answer = calculator.Subtraction(firstNum, secondNum);
                        Console.WriteLine("Answer := {0}", answer);
                        break;
                    case "*":
                        answer = calculator.Multiplication(firstNum, secondNum);
                        Console.WriteLine("Answer := {0}", answer);
                        break;
                    case "/":
                        try {
                            answer = calculator.Division(firstNum, secondNum);
                            Console.WriteLine("Answer := {0}", answer);
                        }
                        catch (ArithmeticException ex) {
                            Console.WriteLine("Exception: "+ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("\t Enter a valid option");
                        break;
                }

                Console.WriteLine("Do you want to Contniue? y/n");
                continueCal = Console.ReadLine();
            }

        }
    }
}
