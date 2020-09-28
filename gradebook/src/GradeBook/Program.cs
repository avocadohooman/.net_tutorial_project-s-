using System;
using System.Collections.Generic;

namespace GradeBook
{
	class Program
	{
		static void Main(string[] args)
		{
			var newBook = new Book("Gary's Book");

			newBook.AddGrade(43.1);
			newBook.AddGrade(31.1);
			newBook.AddGrade(54.1);
			var stats = newBook.getStatistics();
			Console.WriteLine($"The average grade is {stats.Average:N1}.\nThe lowerst grade is: {stats.Low}.\nThe highest grade is: {stats.High}");
			if (args.Length > 0) 
			{
				Console.WriteLine("Hello, " + args[0] + "!");
			}
			else 
			{
				Console.Write("Usage: ./dotnet run <name>");
			}
		}
	}
}
