using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Vehicle
    {
        public Vehicle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vehicle was created!");
            Console.ResetColor();
        }
    }
}