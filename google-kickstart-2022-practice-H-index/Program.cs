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

				int N = int.Parse(Console.ReadLine());

				var current = 0;

				var input = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();

                for (int j = 0; j < N; j++)
                {
					if(input[j]>= 1)
                    {
						current++;
                    }
                }







			}
		}
	}
}