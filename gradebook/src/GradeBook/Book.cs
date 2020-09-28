using System.Collections.Generic;
using System;

namespace GradeBook 
{
    	public class Book
		{
			private List<double> grades;
			public string Name;
			
			public Book(string name)
			{
				if (name.Length == 0) 
				{
					Console.WriteLine("Please choose a name for the book");
				}
				else 
				{
					grades = new List<double>();
					this.Name = name;
				}
			}

			public void AddGrade(double grade)
			{
				this.grades.Add(grade);
			}

			public Statistics getStatistics()
			{
				var result = new Statistics();
				result.Average = 0.0;
				result.High = double.MinValue;
				result.Low = double.MaxValue;
				foreach(var grade in grades) 
				{
					if (grade > result.High) {
						result.High = grade;
					}
					if (grade < result.Low) {
						result.Low = grade;
					}
					result.Average += grade;
				}
				result.Average /= grades.Count;
				return (result);
			}
		}
}