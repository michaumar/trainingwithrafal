using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15;

public class InputControl
{
    public double GetNumericValueFromConsole()
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


    public string GetOperationFromConsole()
    {
        while (true)
        {

            var a = Console.ReadLine();
            if (a == "+" || a == "-" || a == "*" || a == "/")
            {
                Console.WriteLine("Dobre działanie Mordo");
                return a;
            }
            else
            {
                Console.WriteLine("Co żeś tu wpisoł Ciuluu? To jest kalkulator\n" +
              "Podaj jedną z operacji +, -, *, /");
            }
        }

    }

}


