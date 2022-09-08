using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fauna
{
	public class SuperDog : Dog, IFlyingObject
	{
		public SuperDog()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			//Console.WriteLine("SuperDog was created!");
			Console.ResetColor();
		}

		public int Speed { get; set; }
		public void Fly()
		{
			Console.WriteLine("SuperDog is flying");
		}
    }
}