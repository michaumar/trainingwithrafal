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

namespace Lesson;

class Program
{
    static void Main(string[] args)
    {
        double result;
        Console.WriteLine("kalkulator Chopie");


        Console.WriteLine("Type figure a");
        var a = InputControl.GetNumericValueFromConsole();

        Console.WriteLine("Type figure b");
        var b = InputControl.GetNumericValueFromConsole();

        Console.WriteLine("Choose operation +, -, *, /");
        var operation = InputControl.GetOperationFromConsole();

        try
        {
            switch (operation)
            {
                case "+":
                    result = Calculator.Add(a, b);
                    Console.WriteLine($"adding selected {a} + {b} = {result}");
                    break;
                case "-":
                    result = Calculator.Subtract(a, b);
                    Console.WriteLine($"subtraction selected {a} - {b} = {result}");
                    break;
                case "*":
                    result = Calculator.Multiply(a, b);
                    Console.WriteLine($"multiplication selected {a} * {b} = {result}");
                    break;
                case "/":
                    result = Calculator.Divide(a, b);
                    Console.WriteLine($"dividing selected {a} / {b} = {result}");
                    break;
                default:
                    Console.WriteLine("Wracej na gruba!!! Złe działanie");
                    break;
            }

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }


}






