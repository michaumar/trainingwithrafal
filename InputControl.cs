using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15;

public class InputControl
{
    public static double GetNumericValueFromConsole()
    {
        while (true)
        {
            try
            {
                return Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Co żeś tu wpisoł Ciuluu? To jest kalkulator\n" +
              "Podaj liczbe");
            }
        }
    }


    public static string GetOperationFromConsole()
    {
        //to jest mega na siłę i to tego gówniane, try przecież też sprawdza czy operacja jest na liście
        var a = Console.ReadLine();
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

