using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Chicken : Bird
    {

		public Chicken()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Chicken was created!");
            Console.ResetColor();
        }
    }
}