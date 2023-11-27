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
        menu.DisplayMenu();

        Console.WriteLine("Type figure a");
        var variableA = getValueFromConsole.GetNumericValueFromConsole();

        Console.WriteLine("Type figure b");
        var variableB = getValueFromConsole.GetNumericValueFromConsole();

        Console.WriteLine("Choose operation +, -, *, /");
        var operation = getValueFromConsole.GetOperationFromConsole();

        CurrentOperation currentOperationProperties = new CurrentOperation(variableA, operation, variableB);
        Calculator calculatorOperation = new Calculator();

        try
        {
            switch (operation)
            {
                case "+":
                    result = calculatorOperation.Add(variableA, variableB);
                    Console.WriteLine($"adding selected {variableA} {operation} {variableB} = {result}");
                    break;
                case "-":
                    result = calculatorOperation.Subtract(variableA, variableB);
                    Console.WriteLine($"subtraction selected {variableA} {operation} {variableB} = {result}");
                    break;
                case "*":
                    result = calculatorOperation.Multiply(variableA, variableB);
                    Console.WriteLine($"multiplication selected {variableA} {operation} {variableB} = {result}");
                    break;
                case "/":
                    result = calculatorOperation.Divide(variableA, variableB);
                    Console.WriteLine($"dividing selected {variableA} {operation} {variableB} = {result}");
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

        Console.WriteLine("Current operation:\n");
        Console.WriteLine($"{currentOperationProperties.VariableA} {currentOperationProperties.Operation} {currentOperationProperties.VariableB} = {currentOperationProperties.Result}");
    }



}






