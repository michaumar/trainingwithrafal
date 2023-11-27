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
        double result = 0.0;
        InputControl getValueFromConsole = new InputControl();
        Menu menu = new Menu();

        Console.WriteLine("kalkulator Chopie");
        //DisplayMenu();
        Console.WriteLine("Type figure a");
        var a = getValueFromConsole.GetNumericValueFromConsole();

        Console.WriteLine("Type figure b");
        var b = getValueFromConsole.GetNumericValueFromConsole();

        Console.WriteLine("Choose operation +, -, *, /");
        var operation = getValueFromConsole.GetOperationFromConsole();

        CurrentOperation currentOperationProperties = new CurrentOperation(a,operation,b);
        Calculator calculatorOperation = new Calculator();

        try
        {
            switch (operation)
            {
                case "+":
                    result = calculatorOperation.Add(a, b);
                    Console.WriteLine($"adding selected {a} {operation} {b} = {result}");
                    break;
                case "-":
                    result = calculatorOperation.Subtract(a, b);
                    Console.WriteLine($"subtraction selected {a} {operation} {b} = {result}");
                    break;
                case "*":
                    result = calculatorOperation.Multiply(a, b);
                    Console.WriteLine($"multiplication selected {a} {operation} {b} = {result}");
                    break;
                case "/":
                    result = calculatorOperation.Divide(a, b);
                    Console.WriteLine($"dividing selected {a} {operation} {b} = {result}");
                    break;
                default:
                    Console.WriteLine("Something went wrong :/");
                    break;
            }
            currentOperationProperties.Result = result;

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.Clear();
        Console.WriteLine("Current operation:\n");
        Console.WriteLine($"{currentOperationProperties.A} {currentOperationProperties.Operation} {currentOperationProperties.B} = {currentOperationProperties.Result}");
    }



}






