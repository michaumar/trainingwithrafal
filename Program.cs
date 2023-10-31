// Seeusing System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http.Headers;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string operation;

            Console.WriteLine("kalkulator Chopie");

            Console.WriteLine("Type figure a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type figure b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation +, -, *, /");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("adding selected {0} + {1} = {2}", a, b, Add(a, b));
                    break;
                case "-":
                    Console.WriteLine("subtraction selected {0} - {1} = {2}", a, b, Subtract(a, b));
                    break;
                case "*":
                    Console.WriteLine("multiplication selected {0} * {1} = {2}", a, b, Multiply(a, b));
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine("dividing selected {0} / {1} = {2}", a, b, Divide(a, b));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("CIULU!!!!" + e.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Wracej na gruba!!!");
                    break;
            }
        }
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return (a - b);
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {

            //if (b == 0)
            //{
            //    Console.WriteLine("Ciuluuu! /0");
            //    return 0;
            //}
            if (b == 0)
            {
                throw new Exception("/0!");
            }
            return a / b;
            //try
            //{
            //    return a / b;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Ciuluuu! /0");
            //    return 0;
            //}
        }
    }
}






