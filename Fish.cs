using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Fish : Creature, IComparable
    {
		public Fish()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fish was created!");
            Console.ResetColor();
        }

        public void Swim()
        {
            Console.WriteLine("Fish is swimming");
        }

        protected override void Breath()
        {
            Console.WriteLine("Fish is breathing in water");
        }
        public int CompareTo(object obj)
        {
            if (this.Weight > (obj as Creature).Weight)
            {
                return 1;
            }
            else if (this.Weight < (obj as Creature).Weight)
            {
                return -1;
            }
            return 0;
        }
    }
}