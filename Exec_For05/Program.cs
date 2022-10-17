using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int start = 1;
			int end = 5;

			for (int i = start; i <= end; i++)
			{
				string plus = new string('+', end - i);
				Console.Write(plus);

				for (int j = start; j <= i; j++)
				{
					Console.Write(i);
				}
				Console.WriteLine();
			}

			
		}
	}
}
