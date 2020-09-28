using System.Collections.Generic;
using System;

namespace GradeBook 
{
    	class Book
		{
			private List<double> grades;
			private string name;
			
			public Book(string name)
			{
				grades = new List<double>();
				this.name = name;
			}

			public void AddGrade(double grade)
			{
				this.grades.Add(grade);
			}

			public void showStatistics(double lowestGrade, double highestGrade, double sum)
			{
				foreach(var grade in grades) 
				{
					if (grade > highestGrade) {
						highestGrade = grade;
					}
					if (grade < lowestGrade) {
						lowestGrade = grade;
					}
					sum += grade;
				}
				sum /= grades.Count;
				Console.WriteLine($"The average grade is {sum:N1}.\nThe lowerst grade is: {lowestGrade}.\nThe highest grade is: {highestGrade}");
			}
		}
}