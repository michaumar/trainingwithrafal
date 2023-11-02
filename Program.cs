// Seeusing System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0, b = 0.0;
            Console.WriteLine("kalkulator Chopie");

            Console.WriteLine("Type figure a");
            var temp = IsNumber(a);
            a = temp;

            Console.WriteLine("Type figure b");
            var temp2 = IsNumber(b);
            b = temp2;


            Console.WriteLine("Choose operation +, -, *, /");
            var operation = Console.ReadLine();

            double result;
            try
            {
                switch (operation)
                {
                    case "+":
                        result = Add(a, b);
                        Console.WriteLine($"adding selected {a} + {b} = {result}");
                        break;
                    case "-":
                        result = Subtract(a, b);
                        Console.WriteLine($"subtraction selected {a} - {b} = {result}");
                        break;
                    case "*":
                        result = Multiply(a, b);
                        Console.WriteLine($"multiplication selected {a} * {b} = {result}");
                        break;
                    case "/":
                        result = Divide(a, b);
                        Console.WriteLine($"dividing selected {a} / {b} = {result}");
                        break;
                    default:
                        Console.WriteLine("Wracej na gruba!!!");
                        break;
                }

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
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
            if (b == 0)
            {
                throw new DivideByZeroException("ciulu /0!");
            }
            return a / b;
        }

        static double IsNumber(double a)
        {
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                return a;
            }
            catch
            {
                Console.WriteLine("Co żeś tu wpisoł Ciuluu? Zamykam.");
                Environment.Exit(1);
            }

            return 0;
        }
    }
}






