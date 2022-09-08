using System;

namespace Fauna
{
	class Program
	{
		static void Main(string[] args)
		{
            //Sort Dogs

            Dog[] dogs =
			{
				new Dog { Weight = 13 },
				new Dog { Weight = 49 },
				new Dog { Weight = 37 },
				new Dog { Weight = 5 },
				new Dog { Weight = 81 },
			};

			ArrayHelper.Sort(dogs);

			Console.Write("Dogs sorted by weight: ");

			for (int i = 0; i < dogs.Length; i++)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(dogs[i].Weight + ", ");
				Console.ResetColor();
			}
            Console.WriteLine();

			//Sort Superdogs 

			SuperDog[] superdog =
			{

				new SuperDog { Weight = 123 },
				new SuperDog { Weight = 439 },
				new SuperDog { Weight = 347 },
				new SuperDog { Weight = 52 },
				new SuperDog { Weight = 815 },
			};
			ArrayHelper.Sort(superdog);

            Console.Write("Superdogs sorted by weight: ");

            for (int i = 0; i < superdog.Length; i++)
            {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(superdog[i].Weight + ", ");
				Console.ResetColor();
            }

		}
	}
}
