using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Car was created!");
            Console.ResetColor();
        }
    }
}