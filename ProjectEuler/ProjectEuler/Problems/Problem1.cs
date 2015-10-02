using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	class Problem1
	{
		public static void Run()
		{
			int MAX = 1000;
			int count = 0;

			for (int i = 1; i < MAX; i++)
			{
				if (i%3==0 || i%5==0)
				{
					count += i;
				}
			}

			Console.WriteLine(count);
		}
	}
}
