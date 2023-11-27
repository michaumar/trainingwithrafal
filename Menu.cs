﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Menu
    {
        public int DisplayMenu()
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
                        return optionValue;
                    else
                        throw new ArgumentOutOfRangeException();
                }
                catch
                {
                    Console.WriteLine("Wrong! Choose between 1, 2, 3, 4, 5");
                }
            }

        }
    }
}
