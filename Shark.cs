using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Shark : Fish
    {
        public Shark()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Shark was created!");
            Console.ResetColor();
        }
    }
}