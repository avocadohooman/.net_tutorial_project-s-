using System;
using System.Collections.Generic;

namespace GradeBook
{
	class Program
	{
		static void Main(string[] args)
		{
			var newBook = new Book("Gary's Life Story");
			double sum;
			double highestGrade;
			double lowestGrade;

			sum = 0;
			lowestGrade = double.MaxValue;
			highestGrade = double.MinValue;
			newBook.AddGrade(43.1);
			newBook.AddGrade(31.1);
			newBook.AddGrade(54.1);
			newBook.showStatistics(lowestGrade, highestGrade, sum);
			if (args.Length > 0) 
			{
				Console.WriteLine("Hello, " + args[0] + "!");
			}
			else 
			{
				Console.Write("Usage: ./donet run <name>");
			}
		}
	}
}
