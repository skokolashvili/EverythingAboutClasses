using System;
using System.Collections.Generic;
using System.Text;

namespace Fauna
{
    public class Spider : Insect
    {
        public Spider()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Spider was created!");
            Console.ResetColor();
        }
    }
}