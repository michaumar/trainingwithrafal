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
                    Console.WriteLine("Something went wrong :/");
                    break;
            }

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }

        //DisplayCurrentOperation(a, operation, b, result);


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
            }
            catch
            {
                Console.WriteLine("Wrong! Choose between 1, 2, 3, 4, 5");
            }
        }

    }

    public static void DisplayCurrentOperation(double a, string operation, double b, double result)
    {
        Console.WriteLine($"{a}{operation}{b}={result}");
    }







}






