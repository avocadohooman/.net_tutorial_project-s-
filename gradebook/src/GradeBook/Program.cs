using System;
using System.Collections.Generic;

namespace GradeBook
{
	class Program
	{
		static void Main(string[] args)
        {
            var newBook = new Book("Gary's Book");
            newBook.GradeAdded += OnGradeAdded;

            EnterGrades(newBook);
            var stats = newBook.getStatistics();
            Console.WriteLine($"For the book named {newBook.Name}");
            Console.WriteLine($"The average grade is {stats.Average:N1}.\nThe lowest grade is: {stats.Low}.\nThe highest grade is: {stats.High}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        private static void EnterGrades(Book newBook)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    newBook.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
		{
			Console.WriteLine("A Grade was added");
		}
	}
}
