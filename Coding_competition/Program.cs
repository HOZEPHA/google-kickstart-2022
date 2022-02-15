using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			int cou = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < cou; i++)
			{
				string result = $"Case #{i + 1}: ";

				var cons = new char[] { 'a', 'e', 'i', 'o', 'u' };

				string bob = " is ruled by Bob.";
				string alice = " is ruled by Alice.";
				string nobody = " is ruled by nobody.";



				var input = Console.ReadLine();

                if (cons.Contains(input.ToLower()[input.Length - 1]))
                {
					Console.WriteLine(result + input + alice);
                }

				else if (!cons.Contains(input.ToLower()[input.Length - 1]) && input.ToLower()[input.Length-1] != 'y')
                {
					Console.WriteLine(result + input + bob);
                }

                else
                {
					Console.WriteLine(result + input + nobody);
                }


					



			}
		}
	}
}