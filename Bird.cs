using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Bird : Creature, IFlyingObject
    {
		public Bird()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bird was created!");
            Console.ResetColor();
        }

		public int Speed { get; set; }

		public void Fly()
		{
			Console.WriteLine("Bird is flying");
		}

        protected override void Breath()
        {
            Console.WriteLine("Bird is breathing with air");
        }
    }
}