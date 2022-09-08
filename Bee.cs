using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Bee : Insect
    {
		
		public Bee()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bee was created!");
            Console.ResetColor();
        }
    }
}