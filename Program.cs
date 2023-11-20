// Seeusing System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using ConsoleApp15;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace Lesson;

class Program
{
    static void Main(string[] args)
    {
        double result;
        Console.WriteLine("kalkulator Chopie");
        //DisplayMenu();
        Console.WriteLine("Type figure a");
        var a = InputControl.GetNumericValueFromConsole();

        Console.WriteLine("Type figure b");
        var b = InputControl.GetNumericValueFromConsole();

        Console.WriteLine("Choose operation +, -, *, /");
        var operation = InputControl.GetOperationFromConsole();

        CurrentOperation CurrentOperationProperties = new CurrentOperation();

        try
        {
            switch (operation)
            {
                case "+":
                    result = Calculator.Add(a, b);
                    Console.WriteLine($"adding selected {a} {operation} {b} = {result}");
                    CurrentOperationProperties.A = a;
                    CurrentOperationProperties.Operation = operation;
                    CurrentOperationProperties.B = b;
                    CurrentOperationProperties.Result = result;
                    break;
                case "-":
                    result = Calculator.Subtract(a, b);
                    Console.WriteLine($"subtraction selected {a} {operation} {b} = {result}");
                    CurrentOperationProperties.A = a;
                    CurrentOperationProperties.Operation = operation;
                    CurrentOperationProperties.B = b;
                    CurrentOperationProperties.Result = result;
                    break;
                case "*":
                    result = Calculator.Multiply(a, b);
                    Console.WriteLine($"multiplication selected {a} {operation} {b} = {result}");
                    CurrentOperationProperties.A = a;
                    CurrentOperationProperties.Operation = operation;
                    CurrentOperationProperties.B = b;
                    CurrentOperationProperties.Result = result;
                    break;
                case "/":
                    result = Calculator.Divide(a, b);
                    Console.WriteLine($"dividing selected {a} {operation} {b} = {result}");
                    CurrentOperationProperties.A = a;
                    CurrentOperationProperties.Operation = operation;
                    CurrentOperationProperties.B = b;
                    CurrentOperationProperties.Result = result;
                    break;
                default:
                    Console.WriteLine("Something went wrong :/");
                    break;
            }

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.Clear();
        Console.WriteLine("Current operation:\n");
        Console.WriteLine($"{CurrentOperationProperties.A} {CurrentOperationProperties.Operation} {CurrentOperationProperties.B} = {CurrentOperationProperties.Result}");
    }

    public static int DisplayMenu()
    {
        Console.WriteLine("Available options:\n" +
                          "1. Type figures\n" +
                          "2. Choose operation\n" +
                          "3. Clean operation\n" +
                          "4. Delete last action\n" +
                          "5. Do operation");
        while (true)
        {
            try
            {
                var optionValue = int.Parse(Console.ReadLine());
                if (optionValue >= 1 && optionValue <= 5)
                {
                    Console.WriteLine($"Your choice - {optionValue}");
                    return optionValue;
                }
                else
                {
                    Console.WriteLine("Wrong! Choose between 1, 2, 3, 4, 5");
                }
            }
            catch
            {
                Console.WriteLine("Wrong! Choose between 1, 2, 3, 4, 5");
            }
        }

    }

    class CurrentOperation
    {
        private string operation;
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        private double a;
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        private double b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }

        private double result;
        public double Result
        {
            get { return result; }
            set { result = value; }
        }

    }

    public static void DisplayCurrentOperationFunction(double a, string operation, double b, double result)
    {
        CurrentOperation CurrentOperationProperties = new CurrentOperation();

        CurrentOperationProperties.A = a;
        CurrentOperationProperties.Operation = operation;
        CurrentOperationProperties.B = b;
        CurrentOperationProperties.Result = result;

        Console.WriteLine($"{CurrentOperationProperties.A}{CurrentOperationProperties.Operation}{CurrentOperationProperties.B}={CurrentOperationProperties.Result}");
    }






}






