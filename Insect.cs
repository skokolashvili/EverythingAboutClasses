using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Insect : Creature
    {
		public Insect()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Insect was created!");
            Console.ResetColor();
        }

        protected override void Breath()
        {
            Console.WriteLine("Insect is breathing with air");
        }
    }
}