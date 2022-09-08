using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Plane : Vehicle, IFlyingObject
    {
        public Plane()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Plane was created!");
            Console.ResetColor();
        }

		public int Speed { get; set; }

		public void Fly()
        {
            Console.WriteLine("Plane is flying");
        }
    }
}