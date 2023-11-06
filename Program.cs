﻿// Seeusing System;
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
            double a = 0.0, b = 0.0, result;
            string operation = "";
            Console.WriteLine("kalkulator Chopie");

            Console.WriteLine("Type figure a");
            a = InputControl.IsNumber(a);

            Console.WriteLine("Type figure b");
            b = InputControl.IsNumber(b);

            Console.WriteLine("Choose operation +, -, *, /");
            operation = InputControl.IsCorrectOp(operation);

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

    class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return (a - b);
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("ciulu /0!");
            }
            return a / b;
        }

    }

    class InputControl
    {
        public static double IsNumber(double a)
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
                return 0;
            }

        }


        public static string IsCorrectOp(string a)
        {
            //to jest mega na siłę i to tego gówniane, try przecież też sprawdza czy operacja jest na liście
            a = Console.ReadLine();
            if (a == "+" || a == "-" || a == "*" || a == "/")
            {
                Console.WriteLine("Dobre działanie Mordo");
            }
            else
            {
                Console.WriteLine("Co żeś tu wpisoł Ciuluu? Zamykam.");
                Environment.Exit(1);
            }
            return a;
        }
    }


}






