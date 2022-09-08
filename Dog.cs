using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Dog : Animal, IComparable
    {

		public Dog() : base("dog")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Dog was created!");
            Console.ResetColor();
        }

        public Dog(string name) : base(name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dog with name {name} was created!");
            Console.ResetColor();
        }

        public void Bark()
        {
            Console.WriteLine("Dog is barking");
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